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
using System.Data.SqlClient;

namespace Team_4___Clothing_Store
{
    public partial class ProductsData : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        public ProductsData()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            CreateProductForm createProduct = new CreateProductForm();
            createProduct.ShowDialog();
        }

        private void retrieveProducts_Click(object sender, EventArgs e)
        {
            SqlProductRepository products = new SqlProductRepository(connectionString);
            IReadOnlyList<Product> productList = products.RetrieveProducts();
            dataGridView1.DataSource = productList;
        }

        private void retrieveProductTypeCount_Click(object sender, EventArgs e)
        {
            SqlProductRepository products = new SqlProductRepository(connectionString);
            IReadOnlyList<ProductTypeCount> productList = products.RetrieveProductCount();
            dataGridView1.DataSource = productList;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn columnOne = dataGridView1.Columns[0];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnTwo = dataGridView1.Columns[1];
                columnTwo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnThree = dataGridView1.Columns[2];
                columnThree.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ProductsRatingButton_Click(object sender, EventArgs e)
        {
            SqlProductRepository products = new SqlProductRepository(connectionString);
            IReadOnlyList<Product> productList = products.RetrieveHighestRatings();
            dataGridView1.DataSource = productList;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn columnOne = dataGridView1.Columns[0];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FetchProductQuantity_Click(object sender, EventArgs e)
        {
            SetProductTypeForm productTypeForm = new SetProductTypeForm();
            productTypeForm.ShowDialog();
            dataGridView1.DataSource = productTypeForm.productList;

            if(productTypeForm.DialogResult == DialogResult.OK)
            {
                productTypeForm.Close();
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn columnOne = dataGridView1.Columns[1];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
