using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class RetrieveEmployeesDataDelegate : DataReaderDelegate<IReadOnlyList<Employees>>
    {

        public RetrieveEmployeesDataDelegate()
           : base("Sales.RetrieveEmployees")
        {
        }

        public override IReadOnlyList<Employees> Translate(SqlCommand command, IDataRowReader reader)
        {
            var employees = new List<Employees>();

            while (reader.Read())
            {
                employees.Add(new Employees(
                    reader.GetInt32("EmployeeID"),
                    reader.GetString("Email"),
                    reader.GetString("Name"),
                    reader.GetString("EmployeeRole"),
                    reader.GetFloat("Salary")));
            }

            return employees;
        }
    }
}
