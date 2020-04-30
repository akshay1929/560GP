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
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
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
        }
    }
}
