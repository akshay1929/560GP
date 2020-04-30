using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class RetrieveOrdersDataDelegate : DataReaderDelegate<IReadOnlyList<Orders>>
    {

        public RetrieveOrdersDataDelegate()
           : base("Sales.RetrieveOrders")
        {
        }

        public override IReadOnlyList<Orders> Translate(SqlCommand command, IDataRowReader reader)
        {
            var orders = new List<Orders>();

            while (reader.Read())
            {
                orders.Add(new Orders(
                 reader.GetInt32("OrderID"),
                    reader.GetInt32("MemberID"),
                reader.GetInt32("EmployeeID"),
                reader.GetInt32("ShipmentID"),
               reader.GetDateTimeOffset("OrderDate"),
               reader.GetString("ShipmentAddress")));
            }

            return orders;
        }
    }
}
