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
            this.GetOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShipmentAddressLabel = new System.Windows.Forms.Label();
            this.ShipmentAddressTextbox = new System.Windows.Forms.TextBox();
            this.retrieveOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // retrieveOrders
            // 
            this.retrieveOrders.Location = new System.Drawing.Point(449, 204);
            this.retrieveOrders.Name = "retrieveOrders";
            this.retrieveOrders.Size = new System.Drawing.Size(212, 48);
            this.retrieveOrders.TabIndex = 5;
            this.retrieveOrders.Text = "Retrieve Orders";
            this.retrieveOrders.UseVisualStyleBackColor = true;
            this.retrieveOrders.Click += new System.EventHandler(this.retrieveOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 420);
            this.dataGridView1.TabIndex = 6;
            // 
            // OrdersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveOrders);
            this.Controls.Add(this.ShipmentAddressTextbox);
            this.Controls.Add(this.ShipmentAddressLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetOrderButton);
            this.Name = "OrdersData";
            this.Text = "OrdersData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ShipmentAddressLabel;
        private System.Windows.Forms.TextBox ShipmentAddressTextbox;
        private System.Windows.Forms.Button retrieveOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}