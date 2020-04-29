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
            this.SuspendLayout();
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(11, 61);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(275, 190);
            this.EmployeesButton.TabIndex = 0;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // MembersButton
            // 
            this.MembersButton.Location = new System.Drawing.Point(352, 61);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(275, 190);
            this.MembersButton.TabIndex = 1;
            this.MembersButton.Text = "Members";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(694, 61);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(275, 190);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(180, 272);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(275, 190);
            this.ProductsButton.TabIndex = 3;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ShipmentsButton
            // 
            this.ShipmentsButton.Location = new System.Drawing.Point(523, 272);
            this.ShipmentsButton.Name = "ShipmentsButton";
            this.ShipmentsButton.Size = new System.Drawing.Size(275, 190);
            this.ShipmentsButton.TabIndex = 4;
            this.ShipmentsButton.Text = "Shipments";
            this.ShipmentsButton.UseVisualStyleBackColor = true;
            this.ShipmentsButton.Click += new System.EventHandler(this.ShipmentsButton_Click);
            // 
            // MainDataSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 528);
            this.Controls.Add(this.ShipmentsButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.MembersButton);
            this.Controls.Add(this.EmployeesButton);
            this.Name = "MainDataSelection";
            this.Text = "Data Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ShipmentsButton;
    }
}

