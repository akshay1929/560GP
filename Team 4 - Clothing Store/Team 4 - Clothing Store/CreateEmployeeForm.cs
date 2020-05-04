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
    public partial class CreateEmployeeForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        List<Employees> list = new List<Employees>();

        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);

                Employees createEmployees = employees.CreateEmployee(EmailTextbox.Text, NameTextbox.Text, RoleTextbox.Text, Convert.ToInt32(SalaryTextbox.Text));
                list.Add(createEmployees);

                EmployeesData ed = new EmployeesData();
                ed.dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There cannot be any empty parameters.");
            }
        }
    }
}
