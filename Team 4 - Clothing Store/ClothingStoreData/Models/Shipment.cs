using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Shipment
    {
        public int ShipmentID { get; }
        public DateTimeOffset ShipmentDate { get; }
        public string ShipmentAddress { get; }

        internal Shipment(int id, DateTimeOffset dt, string shipmentAddress)
        {
            ShipmentID = id;
            ShipmentDate = dt;
            ShipmentAddress = shipmentAddress;
        }

    }
}
