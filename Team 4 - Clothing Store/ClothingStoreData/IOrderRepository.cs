﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;

namespace ClothingStoreData
{
    interface IOrderRepository
    {
        Orders GetOrder(int id);
        IReadOnlyList<Orders> RetrieveOrders();
        Orders GetOrderId(string shipmentAddress);

        Orders RetrieveOrderCountDateDataDelegate(DateTimeOffset start, DateTimeOffset end);
    }
}
