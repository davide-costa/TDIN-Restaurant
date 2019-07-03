using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;

namespace PaymentTerminal
{
    public partial class PaymentTerminalGUI : Form
    {
        private PaymentTerminal PaymentTerminal;

        public PaymentTerminalGUI()
        {
            InitializeComponent();
            this.Text = "Payment Terminal";
        }

        public void SetPaymentTerminal(PaymentTerminal paymentTerminal)
        {
            this.PaymentTerminal = paymentTerminal;
        }

        private void GetTableAccount(object sender, EventArgs e)
        {
            int tableNumber = (int)numericUpDownTableNumber.Value;
            if (tableNumber <= 0)
                return;

            //clear a possible old table account
            ClearTableOrdersList();

            List<ComplexOrder> tableOrdersToShow;
            try
            {
                tableOrdersToShow = PaymentTerminal.GetTableAccount(tableNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Internal error has occurred", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double totalPrice = 0.0;
            foreach (ComplexOrder complexOrder in tableOrdersToShow)
            {
                string[] newRow = { complexOrder.Product.Id.ToString(), complexOrder.Product.Name.ToString(),
                    complexOrder.Product.Price.ToString(), complexOrder.Quantity.ToString(), complexOrder.Price.ToString() };
                tableOrders.Items.Add(new ListViewItem(newRow));

                totalPrice += complexOrder.Price;
            }

            labelTotalPriceValue.Text = totalPrice.ToString();
        }

        private void ClearTableOrdersList()
        {
            tableOrders.Items.Clear();
        }

        private void OnUpdateStatistics(object sender, EventArgs e)
        {
            BusinessStatistics businessStatistics;
            try
            {
                businessStatistics = PaymentTerminal.GetStatisticsFromServer();
            }
            catch (Exception)
            {
                textBoxStatistics.Text = "Error Getting Statistics";
                return;
            }


            String statistics = "";
            statistics += "Number of tables open: " + businessStatistics.NumberOfOpenTables + Environment.NewLine;
            statistics += "Number of tables closed: " + businessStatistics.NumberOfClosedTables + Environment.NewLine;
            statistics += "Amount already received: " + businessStatistics.AmountAlreadyReceived + " Euros" + Environment.NewLine;
            statistics += "Amount to receive: " + businessStatistics.AmountToReceive + " Euros" + Environment.NewLine;

            textBoxStatistics.Text = statistics;
        }

        private void OnGenerateInvoice(object sender, EventArgs e)
        {
            int tableNumber = (int)numericUpDownTableNumber.Value;
            if (tableOrders.Items.Count == 0 || tableNumber <= 0)
                return;

            try
            {
                PaymentTerminal.CloseTableAndGenerateInvoice(tableNumber);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Table " + tableNumber + " not existent or closed. Please verify table number.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Internal error has occurred", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
