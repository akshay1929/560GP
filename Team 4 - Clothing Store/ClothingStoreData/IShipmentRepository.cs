﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;

namespace ClothingStoreData
{
    interface IShipmentRepository
    {
        IReadOnlyList<Shipment> RetrieveShipments();

        Shipment FetchShipmentDate(int orderid);

        Shipment CreateShipment(DateTimeOffset shipmentdate, string shipmentaddress);
    }
}
