using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Shipment
    {
        public int OrderID { get; }
        public DateTimeOffset ShipmentDate { get; }
        public string ShipmentAddress { get; }

        internal Shipment(int id, DateTimeOffset date, string shipmentAddress)
        {
            OrderID = id;
            ShipmentDate = date;
            ShipmentAddress = ShipmentAddress;
        }

    }
}
