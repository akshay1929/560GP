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
    public partial class EmployeesData : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";

        public EmployeesData()
        {
            InitializeComponent();
        }

        private void RetrieveEmployeesButton_Click(object sender, EventArgs e)
        {
            /*SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);
            IReadOnlyList<Employees> employeeList = employees.RetrieveEmployees();

            foreach(Employees emp in employeeList)
            {
                EmployeesList.Items.Add(emp.Name + " " + emp.Salary);
            }
            */

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Sales.Employees", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }

        }

        private void EmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FetchEmployeeSalaryButton_Click(object sender, EventArgs e)
        {

            SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);
            
            Employees ee = employees.FetchEmployeeSalary(Convert.ToInt32(EmployeeIdTextBox.Text));
            EmployeesList.Items.Add(ee.EmployeeID + " " + ee.Name);
        }

        private void EmployeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
