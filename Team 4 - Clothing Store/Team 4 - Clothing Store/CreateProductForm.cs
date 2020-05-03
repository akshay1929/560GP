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
    public partial class CreateProductForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        List<Product> list = new List<Product>();

        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlProductRepository products = new SqlProductRepository(connectionString);

                Product createProduct = products.CreateProduct(SKUTextbox.Text, NameTextbox.Text, Convert.ToInt32(TypeIdTextbox.Text), Convert.ToInt32(QuantityTextbox.Text), DescriptionTextBox.Text, PriceTextBox.Text, RatingTextbox.Text);
                list.Add(createProduct);

                ProductsData pd = new ProductsData();
                pd.dataGridView1.DataSource = list;

                ProductLabel.Text = "Product Addition Succesful.";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
