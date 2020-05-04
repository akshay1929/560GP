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

        public Shipment FetchShipmentDate(int orderid)
        {
            var d = new FetchShipmentDateDataDelegate(orderid);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Shipment> RetrieveShipments()
        {
            return executor.ExecuteReader(new RetrieveShipmentsDataDelegate());
        }

        public Shipment CreateShipment(DateTimeOffset shipmentdate, string shipmentaddress)
        {
            if (string.IsNullOrWhiteSpace(shipmentaddress))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(shipmentaddress));

            var d = new CreateShipmentDataDelegate(shipmentdate, shipmentaddress);
            return executor.ExecuteNonQuery(d);
        }

        static void Main() {    }
    }
}
