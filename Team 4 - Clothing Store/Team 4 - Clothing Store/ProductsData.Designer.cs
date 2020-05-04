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
            this.retrieveProducts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.retrieveProductTypeCount = new System.Windows.Forms.Button();
            this.ProductsRatingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Location = new System.Drawing.Point(707, 77);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(212, 42);
            this.CreateProductButton.TabIndex = 1;
            this.CreateProductButton.Text = "Add A Product";
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // FetchProductQuantity
            // 
            this.FetchProductQuantity.Location = new System.Drawing.Point(707, 194);
            this.FetchProductQuantity.Name = "FetchProductQuantity";
            this.FetchProductQuantity.Size = new System.Drawing.Size(212, 42);
            this.FetchProductQuantity.TabIndex = 16;
            this.FetchProductQuantity.Text = "Product Quantities For A Category";
            this.FetchProductQuantity.UseVisualStyleBackColor = true;
            this.FetchProductQuantity.Click += new System.EventHandler(this.FetchProductQuantity_Click);
            // 
            // retrieveProducts
            // 
            this.retrieveProducts.Location = new System.Drawing.Point(707, 18);
            this.retrieveProducts.Name = "retrieveProducts";
            this.retrieveProducts.Size = new System.Drawing.Size(212, 43);
            this.retrieveProducts.TabIndex = 18;
            this.retrieveProducts.Text = "Retrieve Products";
            this.retrieveProducts.UseVisualStyleBackColor = true;
            this.retrieveProducts.Click += new System.EventHandler(this.retrieveProducts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 438);
            this.dataGridView1.TabIndex = 19;
            // 
            // retrieveProductTypeCount
            // 
            this.retrieveProductTypeCount.Location = new System.Drawing.Point(707, 135);
            this.retrieveProductTypeCount.Name = "retrieveProductTypeCount";
            this.retrieveProductTypeCount.Size = new System.Drawing.Size(212, 43);
            this.retrieveProductTypeCount.TabIndex = 20;
            this.retrieveProductTypeCount.Text = "Retrieve Product Count";
            this.retrieveProductTypeCount.UseVisualStyleBackColor = true;
            this.retrieveProductTypeCount.Click += new System.EventHandler(this.retrieveProductTypeCount_Click);
            // 
            // ProductsRatingButton
            // 
            this.ProductsRatingButton.Location = new System.Drawing.Point(707, 252);
            this.ProductsRatingButton.Name = "ProductsRatingButton";
            this.ProductsRatingButton.Size = new System.Drawing.Size(212, 42);
            this.ProductsRatingButton.TabIndex = 21;
            this.ProductsRatingButton.Text = "Highest-Rated Products";
            this.ProductsRatingButton.UseVisualStyleBackColor = true;
            this.ProductsRatingButton.Click += new System.EventHandler(this.ProductsRatingButton_Click);
            // 
            // ProductsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 468);
            this.Controls.Add(this.ProductsRatingButton);
            this.Controls.Add(this.retrieveProductTypeCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveProducts);
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
        private System.Windows.Forms.Button retrieveProducts;
        private System.Windows.Forms.Button retrieveProductTypeCount;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ProductsRatingButton;
    }
}