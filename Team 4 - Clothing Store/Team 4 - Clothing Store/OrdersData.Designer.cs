namespace Team_4___Clothing_Store
{
    partial class OrdersData
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
            this.OrdersList = new System.Windows.Forms.ListBox();
            this.GetOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShipmentAddressLabel = new System.Windows.Forms.Label();
            this.ShipmentAddressTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OrdersList
            // 
            this.OrdersList.FormattingEnabled = true;
            this.OrdersList.Location = new System.Drawing.Point(12, 15);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.Size = new System.Drawing.Size(390, 420);
            this.OrdersList.TabIndex = 0;
            // 
            // GetOrderButton
            // 
            this.GetOrderButton.Location = new System.Drawing.Point(449, 15);
            this.GetOrderButton.Name = "GetOrderButton";
            this.GetOrderButton.Size = new System.Drawing.Size(212, 42);
            this.GetOrderButton.TabIndex = 1;
            this.GetOrderButton.Text = "Get Order";
            this.GetOrderButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Order Id";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShipmentAddressLabel
            // 
            this.ShipmentAddressLabel.AutoSize = true;
            this.ShipmentAddressLabel.Location = new System.Drawing.Point(446, 111);
            this.ShipmentAddressLabel.Name = "ShipmentAddressLabel";
            this.ShipmentAddressLabel.Size = new System.Drawing.Size(95, 13);
            this.ShipmentAddressLabel.TabIndex = 3;
            this.ShipmentAddressLabel.Text = "Shipment Address:";
            // 
            // ShipmentAddressTextbox
            // 
            this.ShipmentAddressTextbox.Location = new System.Drawing.Point(561, 108);
            this.ShipmentAddressTextbox.Name = "ShipmentAddressTextbox";
            this.ShipmentAddressTextbox.Size = new System.Drawing.Size(100, 20);
            this.ShipmentAddressTextbox.TabIndex = 4;
            // 
            // OrdersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.ShipmentAddressTextbox);
            this.Controls.Add(this.ShipmentAddressLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetOrderButton);
            this.Controls.Add(this.OrdersList);
            this.Name = "OrdersData";
            this.Text = "OrdersData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrdersList;
        private System.Windows.Forms.Button GetOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ShipmentAddressLabel;
        private System.Windows.Forms.TextBox ShipmentAddressTextbox;
    }
}