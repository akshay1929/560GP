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
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Cicko1999";

        public EmployeesData()
        {
            InitializeComponent();
        }

        private void RetrieveEmployeesButton_Click(object sender, EventArgs e)
        {
            SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);
            IReadOnlyList<Employees> employeeList = employees.RetrieveEmployees();
            dataGridView1.DataSource = employeeList;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn columnOne = dataGridView1.Columns[0];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnTwo = dataGridView1.Columns[2];
                columnTwo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnThree = dataGridView1.Columns[3];
                columnThree.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            try
            {
                SqlEmployeesRepository employees = new SqlEmployeesRepository(connectionString);

                Employees ee = employees.FetchEmployeeSalary(Convert.ToInt32(EmployeeIdTextBox.Text));
                List<Employees> list = new List<Employees>();
                list.Add(ee);
                dataGridView1.DataSource = list;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    DataGridViewColumn columnOne = dataGridView1.Columns[0];
                    columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    DataGridViewColumn columnTwo = dataGridView1.Columns[2];
                    columnTwo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    DataGridViewColumn columnThree = dataGridView1.Columns[3];
                    columnThree.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Incorrect Input. Parameter takes an integer.");
            }
        }

        private void EmployeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm ef = new CreateEmployeeForm();

            ef.ShowDialog();
            if (ef.DialogResult == DialogResult.OK || ef.DialogResult == DialogResult.Cancel)
            {
                ef.Close();
            }
        }

        private void UpdateEmployeeRole_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateEmployeeRoleForm updateForm = new UpdateEmployeeRoleForm();

                updateForm.EmployeeIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateForm.EmployeeIdText.ReadOnly = true;
                updateForm.EmailTextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateForm.NameTextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateForm.SalaryTextbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updateForm.EmployeeRoleText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                updateForm.ShowDialog();

                if (updateForm.DialogResult == DialogResult.OK || updateForm.DialogResult == DialogResult.Cancel)
                {
                    updateForm.Close();
                }
            } catch(NullReferenceException ex)
            {
                MessageBox.Show("Select a Employee.");
            }
        }
    }
}
