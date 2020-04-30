namespace Team_4___Clothing_Store
{
    partial class ShipmentsData
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
            this.ShipmentsList = new System.Windows.Forms.ListBox();
            this.retrieveShipment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipmentsList
            // 
            this.ShipmentsList.FormattingEnabled = true;
            this.ShipmentsList.Location = new System.Drawing.Point(12, 15);
            this.ShipmentsList.Name = "ShipmentsList";
            this.ShipmentsList.Size = new System.Drawing.Size(82, 420);
            this.ShipmentsList.TabIndex = 0;
            // 
            // retrieveShipment
            // 
            this.retrieveShipment.Location = new System.Drawing.Point(538, 29);
            this.retrieveShipment.Name = "retrieveShipment";
            this.retrieveShipment.Size = new System.Drawing.Size(153, 42);
            this.retrieveShipment.TabIndex = 1;
            this.retrieveShipment.Text = "Retrieve Shipments";
            this.retrieveShipment.UseVisualStyleBackColor = true;
            this.retrieveShipment.Click += new System.EventHandler(this.retrieveShipment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 420);
            this.dataGridView1.TabIndex = 2;
            // 
            // ShipmentsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveShipment);
            this.Controls.Add(this.ShipmentsList);
            this.Name = "ShipmentsData";
            this.Text = "ShipmentsData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShipmentsList;
        private System.Windows.Forms.Button retrieveShipment;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}