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
        }

        private void ShipmentsButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeesData ed = new EmployeesData();
            ed.ShowDialog();
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }
    }
}
