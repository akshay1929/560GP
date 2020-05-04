namespace Team_4___Clothing_Store
{
    partial class MainDataSelection
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
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.MembersButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ShipmentsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(28, 118);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(193, 49);
            this.EmployeesButton.TabIndex = 0;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // MembersButton
            // 
            this.MembersButton.Location = new System.Drawing.Point(28, 191);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(193, 49);
            this.MembersButton.TabIndex = 1;
            this.MembersButton.Text = "Members";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(28, 263);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(193, 49);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(28, 336);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(193, 49);
            this.ProductsButton.TabIndex = 3;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ShipmentsButton
            // 
            this.ShipmentsButton.Location = new System.Drawing.Point(28, 409);
            this.ShipmentsButton.Name = "ShipmentsButton";
            this.ShipmentsButton.Size = new System.Drawing.Size(193, 49);
            this.ShipmentsButton.TabIndex = 4;
            this.ShipmentsButton.Text = "Shipments";
            this.ShipmentsButton.UseVisualStyleBackColor = true;
            this.ShipmentsButton.Click += new System.EventHandler(this.ShipmentsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShipmentsButton);
            this.panel1.Controls.Add(this.ProductsButton);
            this.panel1.Controls.Add(this.OrdersButton);
            this.panel1.Controls.Add(this.MembersButton);
            this.panel1.Controls.Add(this.EmployeesButton);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 484);
            this.panel1.TabIndex = 5;
            // 
            // MainDataSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 473);
            this.Controls.Add(this.panel1);
            this.Name = "MainDataSelection";
            this.Text = "Data Selection";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ShipmentsButton;
        private System.Windows.Forms.Panel panel1;
    }
}

