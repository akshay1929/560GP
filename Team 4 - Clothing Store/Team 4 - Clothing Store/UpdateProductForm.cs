using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingStoreData;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;

namespace Team_4___Clothing_Store
{
    public partial class UpdateProductForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Cicko1999";

        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsData ed = new ProductsData();

                SqlProductRepository products = new SqlProductRepository(connectionString);
                products.UpdateProduct(Convert.ToInt32(ProductIdTextbox.Text), SKUTextbox.Text, ProductNameTextbox.Text, Convert.ToInt32(ProductTypeIDTextbox.Text), Convert.ToInt32(QuantityTextbox.Text), DescriptionTextbox.Text, PriceTextbox.Text, RatingTextbox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
