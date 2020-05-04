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
    public partial class UpdateEmployeeRoleForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";

        // public string email;
        // public string name;
        // public int salary;

        public UpdateEmployeeRoleForm()
        {
            InitializeComponent();
        }

        private void UpdateEmployeeRoleButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesData ed = new EmployeesData();

                SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);
                employees.UpdateEmployeeRole(Convert.ToInt32(EmployeeIdText.Text), EmailTextbox.Text, NameTextbox.Text, EmployeeRoleText.Text, Convert.ToInt32(SalaryTextbox.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
