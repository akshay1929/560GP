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
   
    public class GetEmployeeCountDataDelegate : DataReaderDelegate<Employees>
    {
        private readonly string Role;
        public GetEmployeeCountDataDelegate(string s)
         : base("Sales.GetEmployeeCount")
        {
            this.Role = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Role", Role);
        }

        public override Employees Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Employees(
               reader.GetInt32("employeeID"),
               reader.GetString("Email"),
                reader.GetString("Name"),
                reader.GetString("Role"),
               reader.GetFloat("Salary")
               );
        }
    }
}
