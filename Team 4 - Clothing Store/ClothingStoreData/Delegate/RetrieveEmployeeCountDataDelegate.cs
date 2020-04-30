using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using ClothingStoreData.Models;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
   // check implementation
    public class RetrieveEmployeeCountDataDelegate : DataReaderDelegate<IReadOnlyList<Employees>>
    {
        private readonly string Role;

        public RetrieveEmployeeCountDataDelegate(string s)
         : base("Sales.RetrieveEmployeeCount")
        {
            this.Role = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Role", Role);
        }

        public override IReadOnlyList<Employees> Translate(SqlCommand command, IDataRowReader reader)
        {
            var count = new List<Employees>();

            while (reader.Read())
            {
                count.Add(new Employees(
                    reader.GetInt32("employeeID"),
                    reader.GetString("Email"),
                    reader.GetString("Name"),
                    reader.GetString("Role"),
                    reader.GetFloat("Salary")));
            }

            return count;
        }
    }
}
