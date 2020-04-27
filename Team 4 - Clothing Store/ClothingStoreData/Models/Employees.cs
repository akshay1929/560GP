using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Employees
    {
        public int EmployeeID { get; }
        public string Email { get; }
        public string Name { get; }
        public string EmployeeRole { get; }
        public float Salary { get; }

        internal Employees (int employeeID, string email, string name, string role, float salary)
        {
            EmployeeID = employeeID;
            Email = email;
            Name = name;
            EmployeeRole = role;
            Salary = salary;
        }
    }
}
