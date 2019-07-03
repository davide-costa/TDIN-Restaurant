using System;
using System.Windows.Forms;
using Common;

namespace OrderProcessor
{
    public partial class ListOrdersGUI : Form
    {
        private OrderProcessor OrderProcessor;
        delegate ListViewItem LVAddDelegate(ListViewItem lvItem);

        public ListOrdersGUI()
        {
            InitializeComponent();
            this.Text = "Order Processor Terminal";
        }

        public void SetOrderProcessor(OrderProcessor orderProcessor)
        {
            this.OrderProcessor = orderProcessor;
        }

        public void AddNewOrder(ComplexOrder complexOrder)
        {
            string[] newRow = { complexOrder.Id.ToString(), complexOrder.Product.Name,
                complexOrder.Quantity.ToString(), complexOrder.Description};
            LVAddDelegate lvAdd = notPickedOrdersList.Items.Add;
            ListViewItem lvItem = new ListViewItem(newRow);
            BeginInvoke(lvAdd, lvItem);
        }

        private void HandleClickOnMarkOrderAsInPreparationButton(object sender, EventArgs e)
        {
            if (notPickedOrdersList.SelectedItems.Count == 0)
                return;

            MarkOrderAsInPreparation(sender, e);
        }

        private void HandleClickOnMarkOrderAsDoneButton(object sender, EventArgs e)
        {
            if (inPreparationOrdersList.SelectedItems.Count == 0)
                return;

            MarkOrderAsDone(sender, e);
        }

        private void MarkOrderAsInPreparation(object sender, EventArgs e)
        {
            ListViewItem item = notPickedOrdersList.SelectedItems[0];
            notPickedOrdersList.Items.Remove(item);
            inPreparationOrdersList.Items.Add(item);

            try
            {
                OrderProcessor.DeclareOrderInPreparation(Int32.Parse(item.SubItems[0].Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Internal error has occurred", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void MarkOrderAsDone(object sender, EventArgs e)
        {
            ListViewItem item = inPreparationOrdersList.SelectedItems[0];
            inPreparationOrdersList.Items.Remove(item);

            try
            {
                OrderProcessor.DeclareOrderAsDone(Int32.Parse(item.SubItems[0].Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Internal error has occurred", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
