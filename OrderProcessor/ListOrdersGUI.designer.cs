namespace OrderProcessor
{
    partial class ListOrdersGUI
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
            this.notPickedOrdersList = new System.Windows.Forms.ListView();
            this.columnHeaderIdNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNameNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantityNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescriptionNPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markAsInPreparationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.markAsDoneButton = new System.Windows.Forms.Button();
            this.inPreparationOrdersList = new System.Windows.Forms.ListView();
            this.columnHeaderIdIPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNameIPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantityIPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescriptionIPOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // notPickedOrdersList
            // 
            this.notPickedOrdersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdNPOL,
            this.columnHeaderNameNPOL,
            this.columnHeaderQuantityNPOL,
            this.columnHeaderDescriptionNPOL});
            this.notPickedOrdersList.FullRowSelect = true;
            this.notPickedOrdersList.Location = new System.Drawing.Point(12, 68);
            this.notPickedOrdersList.MultiSelect = false;
            this.notPickedOrdersList.Name = "notPickedOrdersList";
            this.notPickedOrdersList.Size = new System.Drawing.Size(581, 603);
            this.notPickedOrdersList.TabIndex = 0;
            this.notPickedOrdersList.UseCompatibleStateImageBehavior = false;
            this.notPickedOrdersList.View = System.Windows.Forms.View.Details;
            this.notPickedOrdersList.DoubleClick += new System.EventHandler(this.MarkOrderAsInPreparation);
            // 
            // columnHeaderIdNPOL
            // 
            this.columnHeaderIdNPOL.Text = "Number";
            this.columnHeaderIdNPOL.Width = 40;
            // 
            // columnHeaderNameNPOL
            // 
            this.columnHeaderNameNPOL.Text = "Name";
            this.columnHeaderNameNPOL.Width = 172;
            // 
            // columnHeaderQuantityNPOL
            // 
            this.columnHeaderQuantityNPOL.Text = "Quantity";
            this.columnHeaderQuantityNPOL.Width = 83;
            // 
            // columnHeaderDescriptionNPOL
            // 
            this.columnHeaderDescriptionNPOL.Text = "Description";
            this.columnHeaderDescriptionNPOL.Width = 282;
            // 
            // markAsInPreparationButton
            // 
            this.markAsInPreparationButton.Location = new System.Drawing.Point(173, 695);
            this.markAsInPreparationButton.Name = "markAsInPreparationButton";
            this.markAsInPreparationButton.Size = new System.Drawing.Size(173, 35);
            this.markAsInPreparationButton.TabIndex = 1;
            this.markAsInPreparationButton.Text = "Mark as In Preparation";
            this.markAsInPreparationButton.UseVisualStyleBackColor = true;
            this.markAsInPreparationButton.Click += new System.EventHandler(this.HandleClickOnMarkOrderAsInPreparationButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not Picked Orders List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(829, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "In Preparation Orders List";
            // 
            // markAsDoneButton
            // 
            this.markAsDoneButton.Location = new System.Drawing.Point(896, 695);
            this.markAsDoneButton.Name = "markAsDoneButton";
            this.markAsDoneButton.Size = new System.Drawing.Size(95, 35);
            this.markAsDoneButton.TabIndex = 10;
            this.markAsDoneButton.Text = "Mark as Done";
            this.markAsDoneButton.UseVisualStyleBackColor = true;
            this.markAsDoneButton.Click += new System.EventHandler(this.HandleClickOnMarkOrderAsDoneButton);
            // 
            // inPreparationOrdersList
            // 
            this.inPreparationOrdersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdIPOL,
            this.columnHeaderNameIPOL,
            this.columnHeaderQuantityIPOL,
            this.columnHeaderDescriptionIPOL});
            this.inPreparationOrdersList.FullRowSelect = true;
            this.inPreparationOrdersList.Location = new System.Drawing.Point(648, 68);
            this.inPreparationOrdersList.MultiSelect = false;
            this.inPreparationOrdersList.Name = "inPreparationOrdersList";
            this.inPreparationOrdersList.Size = new System.Drawing.Size(581, 603);
            this.inPreparationOrdersList.TabIndex = 11;
            this.inPreparationOrdersList.UseCompatibleStateImageBehavior = false;
            this.inPreparationOrdersList.View = System.Windows.Forms.View.Details;
            this.inPreparationOrdersList.DoubleClick += new System.EventHandler(this.MarkOrderAsDone);
            // 
            // columnHeaderIdIPOL
            // 
            this.columnHeaderIdIPOL.Text = "Number";
            this.columnHeaderIdIPOL.Width = 40;
            // 
            // columnHeaderNameIPOL
            // 
            this.columnHeaderNameIPOL.Text = "Name";
            this.columnHeaderNameIPOL.Width = 172;
            // 
            // columnHeaderQuantityIPOL
            // 
            this.columnHeaderQuantityIPOL.Text = "Quantity";
            this.columnHeaderQuantityIPOL.Width = 83;
            // 
            // columnHeaderDescriptionIPOL
            // 
            this.columnHeaderDescriptionIPOL.Text = "Description";
            this.columnHeaderDescriptionIPOL.Width = 282;
            // 
            // ListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 792);
            this.Controls.Add(this.inPreparationOrdersList);
            this.Controls.Add(this.markAsDoneButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markAsInPreparationButton);
            this.Controls.Add(this.notPickedOrdersList);
            this.Name = "ListOrders";
            this.Text = "ListProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView notPickedOrdersList;
        private System.Windows.Forms.ColumnHeader columnHeaderDescriptionNPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderNameNPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantityNPOL;
        private System.Windows.Forms.Button markAsInPreparationButton;
        private System.Windows.Forms.ColumnHeader columnHeaderIdNPOL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button markAsDoneButton;
        private System.Windows.Forms.ListView inPreparationOrdersList;
        private System.Windows.Forms.ColumnHeader columnHeaderIdIPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderNameIPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantityIPOL;
        private System.Windows.Forms.ColumnHeader columnHeaderDescriptionIPOL;
    }
}