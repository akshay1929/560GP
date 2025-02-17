﻿namespace Team_4___Clothing_Store
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
            this.retrieveShipment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIdTextbox = new System.Windows.Forms.TextBox();
            this.RecieveShipmentDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAShipmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retrieveShipment
            // 
            this.retrieveShipment.Location = new System.Drawing.Point(40, 188);
            this.retrieveShipment.Name = "retrieveShipment";
            this.retrieveShipment.Size = new System.Drawing.Size(154, 36);
            this.retrieveShipment.TabIndex = 1;
            this.retrieveShipment.Text = "Retrieve Shipments";
            this.retrieveShipment.UseVisualStyleBackColor = true;
            this.retrieveShipment.Click += new System.EventHandler(this.retrieveShipment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 322);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ID Parameter:";
            // 
            // OrderIdTextbox
            // 
            this.OrderIdTextbox.Location = new System.Drawing.Point(176, 60);
            this.OrderIdTextbox.Name = "OrderIdTextbox";
            this.OrderIdTextbox.Size = new System.Drawing.Size(78, 20);
            this.OrderIdTextbox.TabIndex = 4;
            // 
            // RecieveShipmentDate
            // 
            this.RecieveShipmentDate.Location = new System.Drawing.Point(60, 91);
            this.RecieveShipmentDate.Name = "RecieveShipmentDate";
            this.RecieveShipmentDate.Size = new System.Drawing.Size(194, 50);
            this.RecieveShipmentDate.TabIndex = 5;
            this.RecieveShipmentDate.Text = "Recieve Shipment Date";
            this.RecieveShipmentDate.UseVisualStyleBackColor = true;
            this.RecieveShipmentDate.Click += new System.EventHandler(this.RecieveShipmentDate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.AddAShipmentButton);
            this.panel1.Controls.Add(this.RecieveShipmentDate);
            this.panel1.Controls.Add(this.OrderIdTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.retrieveShipment);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 597);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search Database:";
            // 
            // AddAShipmentButton
            // 
            this.AddAShipmentButton.Location = new System.Drawing.Point(200, 188);
            this.AddAShipmentButton.Name = "AddAShipmentButton";
            this.AddAShipmentButton.Size = new System.Drawing.Size(154, 36);
            this.AddAShipmentButton.TabIndex = 19;
            this.AddAShipmentButton.Text = "Add A Shipment";
            this.AddAShipmentButton.UseVisualStyleBackColor = true;
            this.AddAShipmentButton.Click += new System.EventHandler(this.AddAShipmentButton_Click);
            // 
            // ShipmentsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 590);
            this.Controls.Add(this.panel1);
            this.Name = "ShipmentsData";
            this.Text = "Shipments Data Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button retrieveShipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderIdTextbox;
        private System.Windows.Forms.Button RecieveShipmentDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAShipmentButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}