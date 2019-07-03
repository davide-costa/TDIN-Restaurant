namespace PaymentTerminal
{
    partial class PaymentTerminalGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableOrders = new System.Windows.Forms.ListView();
            this.columnHeaderIdNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNameNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnitaryPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantityNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.numericUpDownTableNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonGetTableAccount = new System.Windows.Forms.Button();
            this.buttonGenerateInvoice = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPriceValue = new System.Windows.Forms.Label();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.textBoxStatistics = new System.Windows.Forms.TextBox();
            this.buttonUpdateStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOrders
            // 
            this.tableOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdNPOL,
            this.columnHeaderNameNPOL,
            this.columnHeaderUnitaryPrice,
            this.columnHeaderQuantityNPOL,
            this.columnHeaderPrice});
            this.tableOrders.FullRowSelect = true;
            this.tableOrders.Location = new System.Drawing.Point(394, 24);
            this.tableOrders.MultiSelect = false;
            this.tableOrders.Name = "tableOrders";
            this.tableOrders.Size = new System.Drawing.Size(394, 351);
            this.tableOrders.TabIndex = 1;
            this.tableOrders.UseCompatibleStateImageBehavior = false;
            this.tableOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIdNPOL
            // 
            this.columnHeaderIdNPOL.Text = "Number";
            this.columnHeaderIdNPOL.Width = 50;
            // 
            // columnHeaderNameNPOL
            // 
            this.columnHeaderNameNPOL.Text = "Name";
            this.columnHeaderNameNPOL.Width = 120;
            // 
            // columnHeaderUnitaryPrice
            // 
            this.columnHeaderUnitaryPrice.Text = "Unitary Price";
            this.columnHeaderUnitaryPrice.Width = 78;
            // 
            // columnHeaderQuantityNPOL
            // 
            this.columnHeaderQuantityNPOL.Text = "Quantity";
            this.columnHeaderQuantityNPOL.Width = 66;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 73;
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableNumber.Location = new System.Drawing.Point(60, 355);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(48, 20);
            this.labelTableNumber.TabIndex = 15;
            this.labelTableNumber.Text = "Table";
            // 
            // numericUpDownTableNumber
            // 
            this.numericUpDownTableNumber.Location = new System.Drawing.Point(169, 355);
            this.numericUpDownTableNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTableNumber.Name = "numericUpDownTableNumber";
            this.numericUpDownTableNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTableNumber.TabIndex = 14;
            this.numericUpDownTableNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonGetTableAccount
            // 
            this.buttonGetTableAccount.Location = new System.Drawing.Point(111, 403);
            this.buttonGetTableAccount.Name = "buttonGetTableAccount";
            this.buttonGetTableAccount.Size = new System.Drawing.Size(145, 35);
            this.buttonGetTableAccount.TabIndex = 13;
            this.buttonGetTableAccount.Text = "Get Table Account";
            this.buttonGetTableAccount.UseVisualStyleBackColor = true;
            this.buttonGetTableAccount.Click += new System.EventHandler(this.GetTableAccount);
            // 
            // buttonGenerateInvoice
            // 
            this.buttonGenerateInvoice.Location = new System.Drawing.Point(413, 403);
            this.buttonGenerateInvoice.Name = "buttonGenerateInvoice";
            this.buttonGenerateInvoice.Size = new System.Drawing.Size(145, 35);
            this.buttonGenerateInvoice.TabIndex = 16;
            this.buttonGenerateInvoice.Text = "Generate Invoice";
            this.buttonGenerateInvoice.UseVisualStyleBackColor = true;
            this.buttonGenerateInvoice.Click += new System.EventHandler(this.OnGenerateInvoice);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(673, 387);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.labelTotalPrice.TabIndex = 17;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelTotalPriceValue
            // 
            this.labelTotalPriceValue.AutoSize = true;
            this.labelTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceValue.Location = new System.Drawing.Point(705, 418);
            this.labelTotalPriceValue.Name = "labelTotalPriceValue";
            this.labelTotalPriceValue.Size = new System.Drawing.Size(31, 20);
            this.labelTotalPriceValue.TabIndex = 18;
            this.labelTotalPriceValue.Text = "0 €";
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsLabel.Location = new System.Drawing.Point(144, 24);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(74, 20);
            this.statisticsLabel.TabIndex = 19;
            this.statisticsLabel.Text = "Statistics";
            // 
            // textBoxStatistics
            // 
            this.textBoxStatistics.Location = new System.Drawing.Point(25, 56);
            this.textBoxStatistics.Multiline = true;
            this.textBoxStatistics.Name = "textBoxStatistics";
            this.textBoxStatistics.ReadOnly = true;
            this.textBoxStatistics.Size = new System.Drawing.Size(320, 188);
            this.textBoxStatistics.TabIndex = 20;
            // 
            // buttonUpdateStatistics
            // 
            this.buttonUpdateStatistics.Location = new System.Drawing.Point(111, 250);
            this.buttonUpdateStatistics.Name = "buttonUpdateStatistics";
            this.buttonUpdateStatistics.Size = new System.Drawing.Size(145, 35);
            this.buttonUpdateStatistics.TabIndex = 21;
            this.buttonUpdateStatistics.Text = "UpdateStatistics";
            this.buttonUpdateStatistics.UseVisualStyleBackColor = true;
            this.buttonUpdateStatistics.Click += new System.EventHandler(this.OnUpdateStatistics);
            // 
            // PaymentTerminalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateStatistics);
            this.Controls.Add(this.textBoxStatistics);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.labelTotalPriceValue);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonGenerateInvoice);
            this.Controls.Add(this.labelTableNumber);
            this.Controls.Add(this.numericUpDownTableNumber);
            this.Controls.Add(this.buttonGetTableAccount);
            this.Controls.Add(this.tableOrders);
            this.Name = "PaymentTerminalGUI";
            this.Text = "Accountant";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView tableOrders;
        private System.Windows.Forms.ColumnHeader columnHeaderIdNPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderNameNPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantityNPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownTableNumber;
        private System.Windows.Forms.Button buttonGetTableAccount;
        private System.Windows.Forms.Button buttonGenerateInvoice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalPriceValue;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.TextBox textBoxStatistics;
        private System.Windows.Forms.Button buttonUpdateStatistics;
        private System.Windows.Forms.ColumnHeader columnHeaderUnitaryPrice;
    }
}