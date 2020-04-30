using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ClothingStoreData
{
    public class SqlShipmentRepository : IShipmentRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlShipmentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Shipment> RetrieveShipments()
        {
            return executor.ExecuteReader(new RetrieveShipmentsDataDelegate());
        }

        static void Main()
        {

        }
    }
}
