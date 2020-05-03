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
    
    public partial class OrdersData : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        public OrdersData()
        {
            InitializeComponent();
        }

        private void retrieveOrders_Click(object sender, EventArgs e)
        {
            SqlOrderRepository orders = new SqlOrderRepository(connectionString);
            IReadOnlyList<Orders> orderList = orders.RetrieveOrders();
            dataGridView1.DataSource = orderList;
        }

        private void orderCount_Click(object sender, EventArgs e)
        {
            SqlOrderRepository orders = new SqlOrderRepository(connectionString);

            OrderCount oo = orders.RetrieveOrderCountDateDataDelegate(startDatePicker.Value, endDatePicker.Value);
            List<OrderCount> list = new List<OrderCount>();
            list.Add(oo);
            dataGridView1.DataSource = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
