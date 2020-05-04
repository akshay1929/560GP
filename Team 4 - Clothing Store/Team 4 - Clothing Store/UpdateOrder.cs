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
    public partial class UpdateOrder : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Cicko1999";

        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersData od = new OrdersData();

                SqlOrderRepository orders = new SqlOrderRepository(connectionString);
                orders.UpdateOrder(Convert.ToInt32(OrderIDTextbox.Text), Convert.ToInt32(MemberIDTextbox.Text), Convert.ToInt32(EmployeeIDTextbox.Text), Convert.ToInt32(ShipmentIDTextbox.Text), Convert.ToDateTime(OrderDateTextBox.Text), ShipmentAddressTextbox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
