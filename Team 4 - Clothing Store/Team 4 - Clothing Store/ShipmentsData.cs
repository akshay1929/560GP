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
    public partial class ShipmentsData : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Cicko1999";
        public ShipmentsData()
        {
            InitializeComponent();
        }

        private void retrieveShipment_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlShipmentRepository shipment = new SqlShipmentRepository(connectionString);
                IReadOnlyList<Shipment> shipmentList = shipment.RetrieveShipments();
                dataGridView1.DataSource = shipmentList;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn columnOne = dataGridView1.Columns[0];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void RecieveShipmentDate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlShipmentRepository shipments = new SqlShipmentRepository(connectionString);

                Shipment s = shipments.FetchShipmentDate(Convert.ToInt32(OrderIdTextbox.Text));
                List<Shipment> list = new List<Shipment>();
                list.Add(s);
                dataGridView1.DataSource = list;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    DataGridViewColumn columnOne = dataGridView1.Columns[0];
                    columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Incorrect input. Parameter takes an integer.");
            }
        }

        private void AddAShipmentButton_Click(object sender, EventArgs e)
        {
            CreateShipmentForm createShipment = new CreateShipmentForm();
            createShipment.ShowDialog();

            if(createShipment.DialogResult == DialogResult.OK || createShipment.DialogResult == DialogResult.Cancel)
            {
                createShipment.Close();
            }
        }
    }
}
