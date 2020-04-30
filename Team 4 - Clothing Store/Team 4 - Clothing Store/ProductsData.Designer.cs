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
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.CreateProductButton = new System.Windows.Forms.Button();
            this.SKUTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.TypeIdTextbox = new System.Windows.Forms.TextBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextbox = new System.Windows.Forms.TextBox();
            this.SKULabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeIdLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.FetchProductQuantity = new System.Windows.Forms.Button();
            this.GetProductNameButton = new System.Windows.Forms.Button();
            this.retrieveProducts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(12, 15);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(76, 420);
            this.ProductsList.TabIndex = 0;
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Location = new System.Drawing.Point(449, 222);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(212, 42);
            this.CreateProductButton.TabIndex = 1;
            this.CreateProductButton.Text = "Create Product";
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // SKUTextbox
            // 
            this.SKUTextbox.Location = new System.Drawing.Point(494, 15);
            this.SKUTextbox.Name = "SKUTextbox";
            this.SKUTextbox.Size = new System.Drawing.Size(167, 20);
            this.SKUTextbox.TabIndex = 2;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(504, 44);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(157, 20);
            this.NameTextbox.TabIndex = 3;
            // 
            // TypeIdTextbox
            // 
            this.TypeIdTextbox.Location = new System.Drawing.Point(515, 73);
            this.TypeIdTextbox.Name = "TypeIdTextbox";
            this.TypeIdTextbox.Size = new System.Drawing.Size(146, 20);
            this.TypeIdTextbox.TabIndex = 4;
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(515, 102);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(146, 20);
            this.QuantityTextbox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(525, 131);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(136, 20);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(504, 160);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(157, 20);
            this.PriceTextBox.TabIndex = 7;
            // 
            // RatingTextbox
            // 
            this.RatingTextbox.Location = new System.Drawing.Point(504, 189);
            this.RatingTextbox.Name = "RatingTextbox";
            this.RatingTextbox.Size = new System.Drawing.Size(157, 20);
            this.RatingTextbox.TabIndex = 8;
            // 
            // SKULabel
            // 
            this.SKULabel.AutoSize = true;
            this.SKULabel.Location = new System.Drawing.Point(446, 18);
            this.SKULabel.Name = "SKULabel";
            this.SKULabel.Size = new System.Drawing.Size(32, 13);
            this.SKULabel.TabIndex = 9;
            this.SKULabel.Text = "SKU:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(446, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // TypeIdLabel
            // 
            this.TypeIdLabel.AutoSize = true;
            this.TypeIdLabel.Location = new System.Drawing.Point(446, 76);
            this.TypeIdLabel.Name = "TypeIdLabel";
            this.TypeIdLabel.Size = new System.Drawing.Size(46, 13);
            this.TypeIdLabel.TabIndex = 11;
            this.TypeIdLabel.Text = "Type Id:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(446, 105);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantityLabel.TabIndex = 12;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(446, 134);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 13;
            this.DescriptionLabel.Text = "Description:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(446, 163);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 14;
            this.PriceLabel.Text = "Price:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(446, 192);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 15;
            this.RatingLabel.Text = "Rating:";
            this.RatingLabel.Click += new System.EventHandler(this.Label7_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(94, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 417);
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
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.TypeIdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SKULabel);
            this.Controls.Add(this.RatingTextbox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.TypeIdTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.SKUTextbox);
            this.Controls.Add(this.CreateProductButton);
            this.Controls.Add(this.ProductsList);
            this.Name = "ProductsData";
            this.Text = "ProductsData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.TextBox SKUTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox TypeIdTextbox;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox RatingTextbox;
        private System.Windows.Forms.Label SKULabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeIdLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Button FetchProductQuantity;
        private System.Windows.Forms.Button GetProductNameButton;
        private System.Windows.Forms.Button retrieveProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}