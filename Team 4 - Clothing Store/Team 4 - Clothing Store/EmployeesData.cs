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
    public partial class EmployeesData : Form// , IEmployeesRepository
    {
        public EmployeesData()
        {
            InitializeComponent();
        }

        private void RetrieveEmployeesButton_Click(object sender, EventArgs e)
        {
            SqlEmployeesRepository employees = SqlEmployeesRepository();
            IReadOnlyList<Employees> employeeList = employees.RetrieveEmployees();

            foreach(Employees emp in employeeList)
            {
                EmployeesList.Text += emp.ToString();
            }
        }

        private void EmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
