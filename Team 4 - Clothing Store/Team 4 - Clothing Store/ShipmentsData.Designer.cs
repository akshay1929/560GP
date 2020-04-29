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
            this.SuspendLayout();
            // 
            // ShipmentsList
            // 
            this.ShipmentsList.FormattingEnabled = true;
            this.ShipmentsList.Location = new System.Drawing.Point(12, 15);
            this.ShipmentsList.Name = "ShipmentsList";
            this.ShipmentsList.Size = new System.Drawing.Size(390, 420);
            this.ShipmentsList.TabIndex = 0;
            // 
            // ShipmentsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.ShipmentsList);
            this.Name = "ShipmentsData";
            this.Text = "ShipmentsData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShipmentsList;
    }
}