using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Common;

namespace DinningRoom
{
    public partial class DinningRoomTerminalGUI : Form
    {
        private DinningRoom DinningRoom;
        delegate ListViewItem ListViewAddItemDelegate(ListViewItem lvItem);
        delegate void ListViewEditItem();

        public DinningRoomTerminalGUI()
        {
            InitializeComponent();
            this.Text = "Dinning Room Terminal";
        }

        public void setDinningRoom(DinningRoom dinningRoom)
        {
            this.DinningRoom = dinningRoom;
        }

        public void OnOrderReadyUpdate(OrderReadyNotification orderReadyNotification)
        {
            string[] row = {orderReadyNotification.Id.ToString(), orderReadyNotification.Order.Product.Name,
                orderReadyNotification.Order.Quantity.ToString(), orderReadyNotification.Order.TableNumber.ToString()};

            ListViewAddItemDelegate listViewAddItemDelegate = listViewNotifications.Items.Add;
            ListViewItem newOrderReadyNotificationEntry = new ListViewItem(row);
            newOrderReadyNotificationEntry.BackColor = Color.DarkRed;
            BeginInvoke(listViewAddItemDelegate, newOrderReadyNotificationEntry);
        }

        public void LoadProducts()
        {
            List<Product> availableProducts = DinningRoom.GetAvailableProducts();
            foreach (Product product in availableProducts)
            {
                string productType;
                productType = product is Food ? "Food" : "Drink";

                string[] newRow = { product.Id.ToString(), product.Name, product.Price.ToString(), productType };
                productsList.Items.Add(new ListViewItem(newRow));
            }
        }

        private void SelectProduct(object sender, EventArgs e)
        {
            ListViewItem selectedItem = productsList.SelectedItems[0];
            //this will not increment an existent one because user may want to have different descriptions to the same product
            string[] row = { selectedItem.SubItems[0].Text, selectedItem.SubItems[1].Text,
                selectedItem.SubItems[2].Text, numericUpDownQuantity.Text, textBoxDescription.Text };
            selectedProductsListView.Items.Add(new ListViewItem(row));

            clearQuantity();
            clearDescription();
        }

        private void HandleAddProductToListOfSelectedObjects(object sender, EventArgs e)
        {
            if (productsList.SelectedItems.Count == 0)
                return;

            SelectProduct(sender, e);
        }

        private void clearDescription()
        {
            textBoxDescription.Text = "";
        }

        private void clearQuantity()
        {
            numericUpDownQuantity.Value = 1;
        }

        private void RemoveSelectedProductFromSelectedProductsList(object sender, EventArgs e)
        {
            if (selectedProductsListView.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = selectedProductsListView.SelectedItems[0];
            selectedProductsListView.Items.Remove(selectedItem);
        }

        protected virtual void SubmitOrder(object sender, EventArgs e)
        {
            if (selectedProductsListView.Items.Count == 0)
            {
                MessageBox.Show("Products must be selected before", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<BasicOrder> basicOrders = BuildOrdersListFromSelectedProductsList();
                DinningRoom.OnNewClientOrder((int)numericUpDownTableNumber.Value, basicOrders);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Table not existent. Select a existent table", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Internal error has occurred", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clearSelectedProductsList();
        }

        private List<BasicOrder> BuildOrdersListFromSelectedProductsList()
        {
            List<BasicOrder> basicOrders = new List<BasicOrder>();

            try
            {
                int tabelNumber = (int)numericUpDownTableNumber.Value;
                foreach (ListViewItem listViewItem in selectedProductsListView.Items)
                {
                    int productId = Int32.Parse(listViewItem.SubItems[0].Text);
                    double price = Double.Parse(listViewItem.SubItems[2].Text);
                    int quantity = Int32.Parse(listViewItem.SubItems[3].Text);
                    string description = listViewItem.SubItems[4].Text;

                    basicOrders.Add(new BasicOrder(productId, price, tabelNumber, quantity, description));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error parsing introduced values", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e);
                throw;
            }

            return basicOrders;
        }

        private void clearSelectedProductsList()
        {
            selectedProductsListView.Items.Clear();
        }

        private void OnNotificationClick(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.BackColor != Color.DarkSeaGreen)
            {
                e.Item.BackColor = Color.DarkSeaGreen;

                int id = Int32.Parse(e.Item.SubItems[0].Text);
                DinningRoom.NotificationHandled(new OrderReadyNotification(id, null));
            }
        }

        public void OnOrderReadyHandledNotification(OrderReadyNotification orderReadyNotification)
        {
            ListViewEditItem listViewEditItem = () =>
            {
                foreach (ListViewItem listViewItem in listViewNotifications.Items)
                {
                    if (listViewItem.SubItems[0] != null &&
                        listViewItem.SubItems[0].Text == orderReadyNotification.Id.ToString())
                    {
                        listViewItem.BackColor = Color.DarkSeaGreen;
                        return;
                    }
                }
            };

            BeginInvoke(listViewEditItem);
        }
    }
}

