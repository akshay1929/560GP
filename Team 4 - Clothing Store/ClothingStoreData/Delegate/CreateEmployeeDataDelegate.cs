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
    internal class CreateEmployeeDataDelegate : NonQueryDataDelegate<Employees>
    {
        public readonly string email;
        public readonly string name;
        public readonly string employeerole;
        public readonly int salary;

        public CreateEmployeeDataDelegate(string email, string name,
           string employeerole, int salary)
           : base("Sales.CreateEmployee")
        {
            this.email = email;
            this.name = name;
            this.employeerole = employeerole;
            this.salary = salary;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Email", SqlDbType.NVarChar);
            p.Value = email;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = name;

            p = command.Parameters.Add("EmployeeRole", SqlDbType.NVarChar);
            p.Value = employeerole;

            p = command.Parameters.Add("Salary", SqlDbType.Int);
            p.Value = salary;

            p = command.Parameters.Add("EmployeeID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Employees Translate(SqlCommand command)
        {
            return new Employees((int)command.Parameters["EmployeeId"].Value, email, name, employeerole, salary);
        }

    }
}
