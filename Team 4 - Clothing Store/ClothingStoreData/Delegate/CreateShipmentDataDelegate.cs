using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;


namespace ClothingStoreData.Delegate
{
    internal class CreateShipmentDataDelegate : NonQueryDataDelegate<Shipment>
    {
        public readonly DateTimeOffset shipmentdate;
        public readonly string shipmentaddress;

        public CreateShipmentDataDelegate(DateTimeOffset shipmentdate, string shipmentaddress)
           : base("Warehouse.CreateShipment")
        {
            this.shipmentdate = shipmentdate;
            this.shipmentaddress = shipmentaddress;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ShipmentDate", SqlDbType.DateTimeOffset);
            p.Value = shipmentdate;

            p = command.Parameters.Add("ShipmentAddress", SqlDbType.NVarChar);
            p.Value = shipmentaddress;

            p = command.Parameters.Add("ShipmentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Shipment Translate(SqlCommand command)
        {
            return new Shipment((int)command.Parameters["ShipmentID"].Value, shipmentdate, shipmentaddress);
        }
    }
}
