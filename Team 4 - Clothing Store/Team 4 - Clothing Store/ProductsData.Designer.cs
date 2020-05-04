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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Location = new System.Drawing.Point(172, 165);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(154, 36);
            this.CreateProductButton.TabIndex = 1;
            this.CreateProductButton.Text = "Add A Product";
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // FetchProductQuantity
            // 
            this.FetchProductQuantity.Location = new System.Drawing.Point(36, 64);
            this.FetchProductQuantity.Name = "FetchProductQuantity";
            this.FetchProductQuantity.Size = new System.Drawing.Size(212, 42);
            this.FetchProductQuantity.TabIndex = 16;
            this.FetchProductQuantity.Text = "Product Quantities For A Category";
            this.FetchProductQuantity.UseVisualStyleBackColor = true;
            this.FetchProductQuantity.Click += new System.EventHandler(this.FetchProductQuantity_Click);
            // 
            // retrieveProducts
            // 
            this.retrieveProducts.Location = new System.Drawing.Point(12, 165);
            this.retrieveProducts.Name = "retrieveProducts";
            this.retrieveProducts.Size = new System.Drawing.Size(154, 36);
            this.retrieveProducts.TabIndex = 18;
            this.retrieveProducts.Text = "Retrieve Products";
            this.retrieveProducts.UseVisualStyleBackColor = true;
            this.retrieveProducts.Click += new System.EventHandler(this.retrieveProducts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1317, 320);
            this.dataGridView1.TabIndex = 19;
            // 
            // retrieveProductTypeCount
            // 
            this.retrieveProductTypeCount.Location = new System.Drawing.Point(651, 64);
            this.retrieveProductTypeCount.Name = "retrieveProductTypeCount";
            this.retrieveProductTypeCount.Size = new System.Drawing.Size(212, 43);
            this.retrieveProductTypeCount.TabIndex = 20;
            this.retrieveProductTypeCount.Text = "Retrieve Product Count";
            this.retrieveProductTypeCount.UseVisualStyleBackColor = true;
            this.retrieveProductTypeCount.Click += new System.EventHandler(this.retrieveProductTypeCount_Click);
            // 
            // ProductsRatingButton
            // 
            this.ProductsRatingButton.Location = new System.Drawing.Point(433, 64);
            this.ProductsRatingButton.Name = "ProductsRatingButton";
            this.ProductsRatingButton.Size = new System.Drawing.Size(212, 42);
            this.ProductsRatingButton.TabIndex = 21;
            this.ProductsRatingButton.Text = "Highest-Rated Products";
            this.ProductsRatingButton.UseVisualStyleBackColor = true;
            this.ProductsRatingButton.Click += new System.EventHandler(this.ProductsRatingButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProductsRatingButton);
            this.panel1.Controls.Add(this.CreateProductButton);
            this.panel1.Controls.Add(this.retrieveProductTypeCount);
            this.panel1.Controls.Add(this.retrieveProducts);
            this.panel1.Controls.Add(this.FetchProductQuantity);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 601);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Report Form(s):";
            // 
            // ProductsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 593);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsData";
            this.Text = "Products Data Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.Button FetchProductQuantity;
        private System.Windows.Forms.Button retrieveProducts;
        private System.Windows.Forms.Button retrieveProductTypeCount;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ProductsRatingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}