using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class RetrieveShipmentsDataDelegate : DataReaderDelegate<IReadOnlyList<Shipment>>
    {

        public RetrieveShipmentsDataDelegate()
           : base("Warehouse.RetrieveShipments")
        {
        }

        public override IReadOnlyList<Shipment> Translate(SqlCommand command, IDataRowReader reader)
        {
            var shipments = new List<Shipment>();

            while (reader.Read())
            {
                shipments.Add(new Shipment(
                    reader.GetInt32("ShipmentID"),
                    reader.GetDateTimeOffset("ShipmentDate"),
                    reader.GetString("ShipmentAddress")
                    ));
            }

            return shipments;
        }
    }
}
