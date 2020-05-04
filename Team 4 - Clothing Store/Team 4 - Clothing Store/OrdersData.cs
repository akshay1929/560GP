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

        private void orderCount_Click(object sender, EventArgs e)
        {
            SqlOrderRepository orders = new SqlOrderRepository(connectionString);

            OrderCount oo = orders.RetrieveOrderCountDateDataDelegate(startDatePicker.Value, endDatePicker.Value);
            List<OrderCount> list = new List<OrderCount>();
            list.Add(oo);
            dataGridView1.DataSource = list;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            UpdateOrder updateForm = new UpdateOrder();

            updateForm.OrderIDTextbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateForm.OrderIDTextbox.ReadOnly = true;
            updateForm.MemberIDTextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateForm.MemberIDTextbox.ReadOnly = true;
            updateForm.EmployeeIDTextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateForm.EmployeeIDTextbox.ReadOnly = true;
            updateForm.ShipmentIDTextbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateForm.ShipmentIDTextbox.ReadOnly = true;
            updateForm.OrderDateTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateForm.ShipmentAddressTextbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            updateForm.ShowDialog();

            if (updateForm.DialogResult == DialogResult.OK || updateForm.DialogResult == DialogResult.Cancel)
            {
                updateForm.Close();
            }
        }
    }
}
