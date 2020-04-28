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
    class GetOrderIdDataDelegate : DataReaderDelegate<Orders>
    {
        private readonly string shipmentAddress;

        public GetOrderIdDataDelegate(string s)
           : base("Warehouse.GetOrderId")
        {
            this.shipmentAddress = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShipmentAddress", shipmentAddress);
        }

        public override Orders Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Orders(
               reader.GetInt32("OrderID"),
               reader.GetInt32("MemberID"),
               reader.GetInt32("EmployeeID"),
               reader.GetInt32("ShipmentID"),
               reader.GetDateTimeOffset("OrderDate"),
               shipmentAddress);
        }
    }
}
