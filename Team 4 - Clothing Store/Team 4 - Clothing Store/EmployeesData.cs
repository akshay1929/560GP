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

            foreach(Employees emp in employeeList)
            {
                EmployeesList.Items.Add(emp.Name + " " + emp.Salary);
            }
        }

        private void EmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
