using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class FetchShipmentDateDataDelegate : DataReaderDelegate<Shipment>
    {
        private readonly int orderid;

        public FetchShipmentDateDataDelegate(int orderid)
           : base("Warehouse.FetchShipmentDate")
        {
            this.orderid = orderid;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenOrderID", orderid);
        }

        public override Shipment Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Shipment(
                  reader.GetInt32("ShipmentID"),
                  reader.GetDateTimeOffset("ShipmentDate"),
                  reader.GetString("ShipmentAddress"));
        }
    }
}
