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
   
    public class GetOrderDataDelegate : DataReaderDelegate<Orders>
    {
        private readonly int orderID;
        public GetOrderDataDelegate(int id)
         : base("Users.GetMemberId")
        {
            this.orderID = id;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("OrderID", orderID);
        }

        public override Orders Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Orders(
               orderID,
               reader.GetInt32("MemberID"),
                reader.GetInt32("EmployeeID"),
                reader.GetInt32("ShipmentID"),
               reader.GetDateTimeOffset("OrderDate"),
               reader.GetString("ShipmentAddress"));
        }
    }
}
