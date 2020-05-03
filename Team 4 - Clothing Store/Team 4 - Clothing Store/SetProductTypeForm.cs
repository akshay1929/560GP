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
    public partial class SetProductTypeForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        public IReadOnlyList<ProductQuantity> productList;

        public SetProductTypeForm()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void GetProductQuantityButton_Click(object sender, EventArgs e)
        {
            SqlProductRepository products = new SqlProductRepository(connectionString);

            productList = products.FetchProductQuantity(Convert.ToInt32(TypeIDTextbox.Text));
        }
    }
}
