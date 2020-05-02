namespace Team_4___Clothing_Store
{
    partial class ProductsData
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
            this.CreateProductButton = new System.Windows.Forms.Button();
            this.FetchProductQuantity = new System.Windows.Forms.Button();
            this.GetProductNameButton = new System.Windows.Forms.Button();
            this.retrieveProducts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Location = new System.Drawing.Point(449, 18);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(212, 42);
            this.CreateProductButton.TabIndex = 1;
            this.CreateProductButton.Text = "Add New Product";
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // FetchProductQuantity
            // 
            this.FetchProductQuantity.Location = new System.Drawing.Point(449, 270);
            this.FetchProductQuantity.Name = "FetchProductQuantity";
            this.FetchProductQuantity.Size = new System.Drawing.Size(212, 42);
            this.FetchProductQuantity.TabIndex = 16;
            this.FetchProductQuantity.Text = "Fetch Product Quantity";
            this.FetchProductQuantity.UseVisualStyleBackColor = true;
            // 
            // GetProductNameButton
            // 
            this.GetProductNameButton.Location = new System.Drawing.Point(449, 318);
            this.GetProductNameButton.Name = "GetProductNameButton";
            this.GetProductNameButton.Size = new System.Drawing.Size(212, 42);
            this.GetProductNameButton.TabIndex = 17;
            this.GetProductNameButton.Text = "Get Product Name";
            this.GetProductNameButton.UseVisualStyleBackColor = true;
            // 
            // retrieveProducts
            // 
            this.retrieveProducts.Location = new System.Drawing.Point(449, 367);
            this.retrieveProducts.Name = "retrieveProducts";
            this.retrieveProducts.Size = new System.Drawing.Size(212, 43);
            this.retrieveProducts.TabIndex = 18;
            this.retrieveProducts.Text = "Retrieve Products";
            this.retrieveProducts.UseVisualStyleBackColor = true;
            this.retrieveProducts.Click += new System.EventHandler(this.retrieveProducts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 417);
            this.dataGridView1.TabIndex = 19;
            // 
            // ProductsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveProducts);
            this.Controls.Add(this.GetProductNameButton);
            this.Controls.Add(this.FetchProductQuantity);
            this.Controls.Add(this.CreateProductButton);
            this.Name = "ProductsData";
            this.Text = "ProductsData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.Button FetchProductQuantity;
        private System.Windows.Forms.Button GetProductNameButton;
        private System.Windows.Forms.Button retrieveProducts;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}