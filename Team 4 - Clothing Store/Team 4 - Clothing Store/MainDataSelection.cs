using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_4___Clothing_Store
{
    public partial class MainDataSelection : Form
    {
        public MainDataSelection()
        {
            InitializeComponent();
            CurrentTimeLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void ShipmentsButton_Click(object sender, EventArgs e)
        {
            ShipmentsData ed = new ShipmentsData();
            ed.ShowDialog();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsData ed = new ProductsData();
            ed.ShowDialog();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeesData ed = new EmployeesData();
            ed.ShowDialog();
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            MembersData ed = new MembersData();
            ed.ShowDialog();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrdersData ed = new OrdersData();
            ed.ShowDialog();
        }
    }
}
