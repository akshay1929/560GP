using System.Collections.Generic;
using DataAccess;
using ClothingStoreData.Models;
using ClothingStoreData.Delegate;
using System;

namespace PersonData
{
    public class SqlShipmentRepository : IOrdersRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlShipmentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public void ShipmentAddress(string ShipmentAddress)
        {
            if (string.IsNullOrWhiteSpace(ShipmentAddress))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(ShipmentAddress));

            var d = new GetShipmentAddressDataDelegate(ShipmentAddress);
            executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Shipment> GetAddress(string shipmentAddress)
        {
            var d = new GetShipmentAddressDataDelegate(shipmentAddress);
            return executor.ExecuteReader(d);
        }
    }
}
