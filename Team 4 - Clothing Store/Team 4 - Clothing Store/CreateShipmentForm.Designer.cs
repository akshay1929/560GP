﻿namespace Team_4___Clothing_Store
{
    partial class CreateShipmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShipmentDateTextbox = new System.Windows.Forms.TextBox();
            this.ShipmentAddressTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateShipmentButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipment Date:";
            // 
            // ShipmentDateTextbox
            // 
            this.ShipmentDateTextbox.Location = new System.Drawing.Point(137, 36);
            this.ShipmentDateTextbox.Name = "ShipmentDateTextbox";
            this.ShipmentDateTextbox.Size = new System.Drawing.Size(205, 20);
            this.ShipmentDateTextbox.TabIndex = 1;
            // 
            // ShipmentAddressTextbox
            // 
            this.ShipmentAddressTextbox.Location = new System.Drawing.Point(156, 65);
            this.ShipmentAddressTextbox.Name = "ShipmentAddressTextbox";
            this.ShipmentAddressTextbox.Size = new System.Drawing.Size(186, 20);
            this.ShipmentAddressTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shipment Address:";
            // 
            // CreateShipmentButton
            // 
            this.CreateShipmentButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateShipmentButton.Location = new System.Drawing.Point(38, 101);
            this.CreateShipmentButton.Name = "CreateShipmentButton";
            this.CreateShipmentButton.Size = new System.Drawing.Size(112, 42);
            this.CreateShipmentButton.TabIndex = 4;
            this.CreateShipmentButton.Text = "OK";
            this.CreateShipmentButton.UseVisualStyleBackColor = true;
            this.CreateShipmentButton.Click += new System.EventHandler(this.CreateShipmentButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(230, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreateShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateShipmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShipmentAddressTextbox);
            this.Controls.Add(this.ShipmentDateTextbox);
            this.Controls.Add(this.label1);
            this.Name = "CreateShipmentForm";
            this.Text = "Add A Shipment ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShipmentDateTextbox;
        private System.Windows.Forms.TextBox ShipmentAddressTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateShipmentButton;
        private System.Windows.Forms.Button button2;
    }
}