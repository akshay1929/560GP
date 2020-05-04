using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;


namespace ClothingStoreData.Delegate
{
    internal class UpdateEmployeeRoleDataDelegate : DataDelegate
    {
        public readonly int employeeid;
        public readonly string email;
        public readonly string name;
        public readonly string employeerole;
        public readonly int salary;

        public UpdateEmployeeRoleDataDelegate(int employeeid, string email, string name,
           string employeerole, int salary)
           : base("Sales.UpdateEmployeeRole")
        {
            this.employeeid = employeeid;
            this.email = email;
            this.name = name;
            this.employeerole = employeerole;
            this.salary = salary;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenEmployeeID", employeeid);
            command.Parameters.AddWithValue("GivenEmail", email);
            command.Parameters.AddWithValue("GivenName", name);
            command.Parameters.AddWithValue("GivenEmployeeRole", employeerole);
            command.Parameters.AddWithValue("GivenSalary", salary);
        }
    }
}
