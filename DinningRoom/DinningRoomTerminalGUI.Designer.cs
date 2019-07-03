namespace DinningRoom
{
    partial class DinningRoomTerminalGUI
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
            this.productsList = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.selectedProductsListView = new System.Windows.Forms.ListView();
            this.columnHeaderIdSPL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNameSPL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriceSPL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.removeProductFromOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonSubmitOrder = new System.Windows.Forms.Button();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.numericUpDownTableNumber = new System.Windows.Forms.NumericUpDown();
            this.labelNotifications = new System.Windows.Forms.Label();
            this.listViewNotifications = new System.Windows.Forms.ListView();
            this.columnHeaderProducNameN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuatityN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTableNumberN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNotificationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // productsList
            // 
            this.productsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderPrice,
            this.columnHeaderType});
            this.productsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsList.FullRowSelect = true;
            this.productsList.Location = new System.Drawing.Point(12, 68);
            this.productsList.MultiSelect = false;
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(350, 445);
            this.productsList.TabIndex = 0;
            this.productsList.UseCompatibleStateImageBehavior = false;
            this.productsList.View = System.Windows.Forms.View.Details;
            this.productsList.DoubleClick += new System.EventHandler(this.SelectProduct);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Number";
            this.columnHeaderId.Width = 40;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Product Name";
            this.columnHeaderName.Width = 172;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 83;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 50;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(128, 725);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 35);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.HandleAddProductToListOfSelectedObjects);
            // 
            // selectedProductsListView
            // 
            this.selectedProductsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdSPL,
            this.columnHeaderNameSPL,
            this.columnHeaderPriceSPL,
            this.columnHeaderQuantity,
            this.columnHeaderDescription});
            this.selectedProductsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedProductsListView.FullRowSelect = true;
            this.selectedProductsListView.Location = new System.Drawing.Point(414, 68);
            this.selectedProductsListView.MultiSelect = false;
            this.selectedProductsListView.Name = "selectedProductsListView";
            this.selectedProductsListView.Size = new System.Drawing.Size(450, 445);
            this.selectedProductsListView.TabIndex = 2;
            this.selectedProductsListView.UseCompatibleStateImageBehavior = false;
            this.selectedProductsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIdSPL
            // 
            this.columnHeaderIdSPL.Text = "Number";
            this.columnHeaderIdSPL.Width = 50;
            // 
            // columnHeaderNameSPL
            // 
            this.columnHeaderNameSPL.Text = "Product Name";
            this.columnHeaderNameSPL.Width = 132;
            // 
            // columnHeaderPriceSPL
            // 
            this.columnHeaderPriceSPL.Text = "Price";
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.Width = 58;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Products List";
            // 
            // removeProductFromOrderButton
            // 
            this.removeProductFromOrderButton.Location = new System.Drawing.Point(472, 529);
            this.removeProductFromOrderButton.Name = "removeProductFromOrderButton";
            this.removeProductFromOrderButton.Size = new System.Drawing.Size(95, 35);
            this.removeProductFromOrderButton.TabIndex = 4;
            this.removeProductFromOrderButton.Text = "Remove";
            this.removeProductFromOrderButton.UseVisualStyleBackColor = true;
            this.removeProductFromOrderButton.Click += new System.EventHandler(this.RemoveSelectedProductFromSelectedProductsList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected Products List";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(128, 529);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 6;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(19, 529);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(19, 578);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 20);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(128, 578);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(217, 124);
            this.textBoxDescription.TabIndex = 9;
            // 
            // buttonSubmitOrder
            // 
            this.buttonSubmitOrder.Location = new System.Drawing.Point(622, 725);
            this.buttonSubmitOrder.Name = "buttonSubmitOrder";
            this.buttonSubmitOrder.Size = new System.Drawing.Size(95, 35);
            this.buttonSubmitOrder.TabIndex = 10;
            this.buttonSubmitOrder.Text = "Submit Order";
            this.buttonSubmitOrder.UseVisualStyleBackColor = true;
            this.buttonSubmitOrder.Click += new System.EventHandler(this.SubmitOrder);
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableNumber.Location = new System.Drawing.Point(513, 627);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(48, 20);
            this.labelTableNumber.TabIndex = 12;
            this.labelTableNumber.Text = "Table";
            // 
            // numericUpDownTableNumber
            // 
            this.numericUpDownTableNumber.Location = new System.Drawing.Point(622, 627);
            this.numericUpDownTableNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTableNumber.Name = "numericUpDownTableNumber";
            this.numericUpDownTableNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTableNumber.TabIndex = 11;
            this.numericUpDownTableNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNotifications
            // 
            this.labelNotifications.AutoSize = true;
            this.labelNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotifications.Location = new System.Drawing.Point(1034, 23);
            this.labelNotifications.Name = "labelNotifications";
            this.labelNotifications.Size = new System.Drawing.Size(130, 25);
            this.labelNotifications.TabIndex = 13;
            this.labelNotifications.Text = "Notifications";
            // 
            // listViewNotifications
            // 
            this.listViewNotifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNotificationId,
            this.columnHeaderProducNameN,
            this.columnHeaderQuatityN,
            this.columnHeaderTableNumberN});
            this.listViewNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNotifications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listViewNotifications.FullRowSelect = true;
            this.listViewNotifications.LabelWrap = false;
            this.listViewNotifications.Location = new System.Drawing.Point(919, 68);
            this.listViewNotifications.MultiSelect = false;
            this.listViewNotifications.Name = "listViewNotifications";
            this.listViewNotifications.Size = new System.Drawing.Size(350, 445);
            this.listViewNotifications.TabIndex = 14;
            this.listViewNotifications.UseCompatibleStateImageBehavior = false;
            this.listViewNotifications.View = System.Windows.Forms.View.Details;
            this.listViewNotifications.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnNotificationClick);
            // 
            // columnHeaderProducNameN
            // 
            this.columnHeaderProducNameN.Text = "Product Name";
            this.columnHeaderProducNameN.Width = 146;
            // 
            // columnHeaderQuatityN
            // 
            this.columnHeaderQuatityN.Text = "Quantity";
            this.columnHeaderQuatityN.Width = 74;
            // 
            // columnHeaderTableNumberN
            // 
            this.columnHeaderTableNumberN.Text = "Table Number";
            this.columnHeaderTableNumberN.Width = 93;
            // 
            // columnHeaderNotificationId
            // 
            this.columnHeaderNotificationId.Text = "Id";
            this.columnHeaderNotificationId.Width = 32;
            // 
            // DinningRoomTerminalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 804);
            this.Controls.Add(this.listViewNotifications);
            this.Controls.Add(this.labelNotifications);
            this.Controls.Add(this.labelTableNumber);
            this.Controls.Add(this.numericUpDownTableNumber);
            this.Controls.Add(this.buttonSubmitOrder);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeProductFromOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedProductsListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productsList);
            this.Name = "DinningRoomTerminalGUI";
            this.Text = "ListProducts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTableNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productsList;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ListView selectedProductsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderIdSPL;
        private System.Windows.Forms.ColumnHeader columnHeaderNameSPL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeProductFromOrderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSubmitOrder;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownTableNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderPriceSPL;
        private System.Windows.Forms.Label labelNotifications;
        private System.Windows.Forms.ListView listViewNotifications;
        private System.Windows.Forms.ColumnHeader columnHeaderProducNameN;
        private System.Windows.Forms.ColumnHeader columnHeaderQuatityN;
        private System.Windows.Forms.ColumnHeader columnHeaderTableNumberN;
        private System.Windows.Forms.ColumnHeader columnHeaderNotificationId;
    }
}