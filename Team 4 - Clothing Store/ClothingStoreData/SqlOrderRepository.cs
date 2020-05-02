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

        public Orders GetOrder(int id)
        {
            var d = new GetOrderDataDelegate(id);
            return executor.ExecuteReader(d);
        }

        public Orders GetOrderId(string shipmentAddress)
        {
            var d = new GetOrderIdDataDelegate(shipmentAddress);
            return executor.ExecuteReader(d);
        }
        public Orders RetrieveOrderCountDateDataDelegate(DateTimeOffset start, DateTimeOffset end)
        {
            var d = new RetrieveOrderCountDateDataDelegate(start, end);
            return executor.ExecuteReader(d);
        }
        public IReadOnlyList<Orders> RetrieveOrders()
        {
            return executor.ExecuteReader(new RetrieveOrdersDataDelegate());
        }
    }
}
