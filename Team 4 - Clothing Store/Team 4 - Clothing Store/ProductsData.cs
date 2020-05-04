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
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Cicko1999";
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

            if(createProduct.DialogResult == DialogResult.OK || createProduct.DialogResult == DialogResult.Cancel)
            {
                createProduct.Close();
            }
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
                DataGridViewColumn columnOne = dataGridView1.Columns[2];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateForm = new UpdateProductForm();

            updateForm.ProductIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateForm.ProductIdText.ReadOnly = true;
            updateForm.SKUTextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateForm.ProductNameTextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateForm.QuantityTextbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateForm.ProductTypeIDTextbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            updateForm.ShowDialog();

            if (updateForm.DialogResult == DialogResult.OK || updateForm.DialogResult == DialogResult.Cancel)
            {
                updateForm.Close();
            }
        }
    }
}
