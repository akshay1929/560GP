using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Shipment
    {
        public string ShipmentAddress { get; }

        internal Shipment(string shipmentAddress)
        {
            ShipmentAddress = ShipmentAddress;
        }

    }
}
