using System;
using System.Collections.Generic;
using Common;

[Serializable]
class CentralNode : MarshalByRefObject, ICentralNode
{
    private List<Table> Tables = new List<Table>();
    private List<ComplexOrder> OldOrders = new List<ComplexOrder>();
    private List<Product> Products = new List<Product>();
    private Dictionary<int, Product> ProdutIdToProduct = new Dictionary<int, Product>();
    private Dictionary<int, ComplexOrder> Orders = new Dictionary<int, ComplexOrder>();
    public event EventHandler<ComplexOrder> NewKitchenClientOrder;
    public event EventHandler<ComplexOrder> NewBarClientOrder;
    public event EventHandler<OrderReadyNotification> OrderReady;
    public event EventHandler<string> PrintInvoice;
    public event EventHandler<OrderReadyNotification> OrderReadyNotificationHandled;


    public CentralNode()
    {
        CreateNTables(10);

        if (!(Utils.LoadObjectToFileAsBinary("products.data") is List<Product> products))
        {
            Console.WriteLine("Error loading restaurant products. The program will terminate.");
            return;
        }

        foreach (Product product in products)
            AddProductToRestaurant(product);
    }

    private void AddProductToRestaurant(Product product)
    {
        Products.Add(product);
        ProdutIdToProduct.Add(product.Id, product);
    }

    public List<Product> GetRestaurantAvailableProducts()
    {
        return Products;
    }

    public override object InitializeLifetimeService()
    {
        return null;
    }

    public void CreateNTables(int n)
    {
        for (int i = 0; i < n; i++)
            Tables.Add(new Table());
    }

    public void RegisterOrdersForTable(int tableNumber, List<BasicOrder> basicOrders)
    {
        Table table = Tables.Find(t => ((Table)t).Number == tableNumber);
        if (table == null)
            throw new KeyNotFoundException("Table not found");

        List<ComplexOrder> complexOrders = createComplexOrders(basicOrders);
        table.AddOrders(complexOrders);

        //add orders to the map of orders being processed (not yet archived)
        foreach (ComplexOrder order in complexOrders)
            Orders.Add(order.Id, order);

        //notify kitchen and bar
        NotifyKitchenAndBar(complexOrders);
    }

    private List<ComplexOrder> createComplexOrders(List<BasicOrder> basicOrders)
    {
        List<ComplexOrder> ordersCopy = new List<ComplexOrder>();
        foreach (BasicOrder basicOrder in basicOrders)
        {
            Product product = ProdutIdToProduct[basicOrder.ProductId];
            ordersCopy.Add(new ComplexOrder(product, basicOrder.TableNumber,
                basicOrder.State, basicOrder.Quantity, basicOrder.Description));
        }

        return ordersCopy;
    }

    private void NotifyKitchenAndBar(List<ComplexOrder> complexOrders)
    {
        foreach (ComplexOrder order in complexOrders)
        {
            if (order.Product is Food)
            {
                if (NewKitchenClientOrder != null)
                    NewKitchenClientOrder(this, order);
            }
            else if (NewBarClientOrder != null)
                NewBarClientOrder(this, order);
        }
    }

    public int GetNumberOfOpenTables()
    {
        return Tables.FindAll(t => t.State == Table.state.OPEN).Count;
    }

    public int GetNumberOfClosedTables()
    {
        return Tables.FindAll(t => t.State == Table.state.CLOSED).Count;
    }

    public double GetAmountAlreadyReceived()
    {
        double amountAlreadyReceived = 0.0;
        foreach (Order order in OldOrders)
        {
            amountAlreadyReceived += order.Price;
        }

        return amountAlreadyReceived;
    }

    //Amount of the orders that are already in preparation or served in open tables
    public double GetAmountToReceive()
    {
        double amountToReceive = 0.0;
        foreach (Table table in Tables)
        {
            foreach (ComplexOrder order in table.Orders)
            {
                amountToReceive += order.Price;
            }
        }

        return amountToReceive;
    }

    public void DeclareOrderAsDone(int orderId)
    {
        SetOrderStateAsDone(orderId);
        OrderReadyNotification orderReadyNotification = new OrderReadyNotification(Orders[orderId]);
        if (OrderReady != null)
            OrderReady(this, orderReadyNotification);
    }

    public void DeclareOrderInPreparation(int orderId)
    {
        SetOrderStateAsInPreparation(orderId);
    }

    private void SetOrderStateAsInPreparation(int orderId)
    {
        Order order = Orders[orderId];
        order.State = Order.state.IN_PREPARATION;
    }

    private void SetOrderStateAsDone(int orderId)
    {
        Order order = Orders[orderId];
        order.State = Order.state.READY;
    }

    public string GenerateInvoiceString(List<ComplexOrder> tableOrders, int tableNumber)
    {
        string formattedTime = DateTime.Now.ToString(" dd-MM-yyyy hh:mm:ss");
        string invoice = ("Invoice Table " + tableNumber + " at " + formattedTime + "\n\n").PadLeft(15);

        invoice += "Name".PadRight(20) + "Unit Price".PadRight(15) +
                         "Quantity".PadRight(15) + "Price".PadRight(15) + "\n\n";

        double totalValue = 0.0;
        foreach (ComplexOrder complexOrder in tableOrders)
        {
            string productName = complexOrder.Product.Name;
            double unitaryPrice = complexOrder.Product.Price;
            int quantity = complexOrder.Quantity;
            double orderPrice = complexOrder.Price;
            totalValue += orderPrice;

            invoice += productName.PadRight(20) + unitaryPrice.ToString().PadRight(15) +
                       quantity.ToString().PadRight(15) + orderPrice.ToString().PadRight(15) + "\n\n";
        }

        invoice += "\n" + "Total Value".PadRight(20 + 15 + 15) + totalValue;

        return invoice;
    }

    public double CloseTableAndGenerateInvoice(int tableNumber)
    {
        Table tableToClose = Tables.Find(t => t.Number == tableNumber && t.State == Table.state.OPEN);
        if (tableToClose == null)
            throw new KeyNotFoundException();

        List<ComplexOrder> tableOrders = tableToClose.Close();
        //Remove order from the map of orders currently being processed
        foreach (ComplexOrder complexOrder in tableOrders)
            Orders.Remove(complexOrder.Id);

        //archive it in the list OldOrders
        OldOrders.AddRange(tableOrders);

        double orderTotal = 0;

        foreach (Order order in tableOrders)
            orderTotal += order.Price;

        //print Invoice
        String generatedInvoiceString = GenerateInvoiceString(tableOrders, tableNumber);
        if (PrintInvoice != null)
            PrintInvoice(this, generatedInvoiceString);

        return orderTotal;
    }

    public List<ComplexOrder> GetTableOrdersList(int tableNumber)
    {
        return Tables.Find(t => t.Number == tableNumber).Orders;
    }

    public void HandleOrderReadyNotificationHandled(OrderReadyNotification orderReadyNotification)
    {
        if (OrderReadyNotificationHandled != null)
            OrderReadyNotificationHandled(this, orderReadyNotification);
    }

    public BusinessStatistics GetBusinessStatistics()
    {
        BusinessStatistics businessStatistics = new BusinessStatistics
        {
            NumberOfOpenTables = GetNumberOfOpenTables(),
            NumberOfClosedTables = GetNumberOfClosedTables(),
            AmountAlreadyReceived = GetAmountAlreadyReceived(),
            AmountToReceive = GetAmountToReceive()
        };

        return businessStatistics;
    }
}