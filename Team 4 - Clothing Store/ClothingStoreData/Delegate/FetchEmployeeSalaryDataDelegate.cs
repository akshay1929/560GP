using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class FetchEmployeeSalaryDataDelegate : DataReaderDelegate<Employees>
    {
        private readonly int employeeid;

        public FetchEmployeeSalaryDataDelegate(int employeeid)
           : base("Sales.FetchEmployeeSalary")
        {
            this.employeeid = employeeid;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenEmployeeID", employeeid);
        }

        public override Employees Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Employees(
               employeeid,
               reader.GetString("Email"),
               reader.GetString("Name"),
               reader.GetString("EmployeeRole"),
               reader.GetInt32("Salary"));
        }
    }
}
