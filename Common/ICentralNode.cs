using System;
using System.Collections.Generic;

namespace Common
{
    public interface ICentralNode
    {
        event EventHandler<ComplexOrder> NewKitchenClientOrder;
        event EventHandler<ComplexOrder> NewBarClientOrder;
        event EventHandler<OrderReadyNotification> OrderReady;
        event EventHandler<string> PrintInvoice;
        event EventHandler<OrderReadyNotification> OrderReadyNotificationHandled;

        List<Product> GetRestaurantAvailableProducts();
        void RegisterOrdersForTable(int tableNumber, List<BasicOrder> orders);

        void DeclareOrderInPreparation(int orderId);
        void DeclareOrderAsDone(int orderId);

        //This method is called remotely by Accounting, it returns the price
        double CloseTableAndGenerateInvoice(int tableNumber);

        BusinessStatistics GetBusinessStatistics();
        List<ComplexOrder> GetTableOrdersList(int tableNumber);
        void HandleOrderReadyNotificationHandled(OrderReadyNotification orderReadyNotification);
    }
}

