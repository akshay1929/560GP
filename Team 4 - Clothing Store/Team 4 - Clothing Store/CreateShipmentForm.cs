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
    public partial class CreateShipmentForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        List<Shipment> list = new List<Shipment>();

        public CreateShipmentForm()
        {
            InitializeComponent();
        }

        private void CreateShipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlShipmentRepository shipments = new SqlShipmentRepository(connectionString);

                Shipment createShipment = shipments.CreateShipment(Convert.ToDateTime(ShipmentDateTextbox.Text), ShipmentAddressTextbox.Text);
                list.Add(createShipment);

                ShipmentsData sd = new ShipmentsData();
                sd.dataGridView1.DataSource = list;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
