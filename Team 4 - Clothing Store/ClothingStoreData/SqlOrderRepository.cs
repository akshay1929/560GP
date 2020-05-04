using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ClothingStoreData
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlOrderRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public OrderCount RetrieveOrderCount(DateTimeOffset start, DateTimeOffset end)
        {
            var d = new RetrieveOrderCountDateDataDelegate(start, end);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Orders> RetrieveOrders()
        {
            return executor.ExecuteReader(new RetrieveOrdersDataDelegate());
        }

        public void UpdateOrder(int orderid, int memberid, int employeeid, int shipmentid, DateTimeOffset orderdate, string shipmentaddress)
        {
            if (shipmentaddress == null)
                throw new ArgumentNullException(nameof(shipmentaddress));

            var d = new UpdateOrderDataDelegate(orderid, memberid, employeeid, shipmentid, orderdate, shipmentaddress);
            executor.ExecuteNonQuery(d);
        }
    }
}
