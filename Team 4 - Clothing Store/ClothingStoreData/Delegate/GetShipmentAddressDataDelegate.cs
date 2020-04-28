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
    class GetShipmentAddressDataDelegate : DataReaderDelegate<Shipment>
    {
        private readonly string shipmentAddress;
        public GetShipmentAddressDataDelegate(string s)
           : base("Warehouse.GetShipmentAddress")
        {
            this.shipmentAddress = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShipmentAddress", shipmentAddress);
        }

        public override Shipment Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Shipment(
               reader.GetString("ShipmentAddress")
               );

        }
    }
}
