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
            SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);
            IReadOnlyList<Employees> employeeList = employees.RetrieveEmployees();
            dataGridView1.DataSource = employeeList;
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
            List<Employees> list = new List<Employees>();
            list.Add(ee);
            dataGridView1.DataSource = list;
            
        }

        private void EmployeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm ef = new CreateEmployeeForm();
            ef.ShowDialog();
        }

        private void UpdateEmployeeRole_Click(object sender, EventArgs e)
        {
            UpdateEmployeeRoleForm updateForm = new UpdateEmployeeRoleForm();

            updateForm.EmployeeIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateForm.EmployeeIdText.ReadOnly = true;
            updateForm.email = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateForm.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateForm.salary = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            updateForm.EmployeeRoleText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            updateForm.ShowDialog();
        }
    }
}
