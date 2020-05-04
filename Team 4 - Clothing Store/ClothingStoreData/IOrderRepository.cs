using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;

namespace ClothingStoreData
{
    interface IOrderRepository
    {
        IReadOnlyList<Orders> RetrieveOrders();

        OrderCount RetrieveOrderCount(DateTimeOffset start, DateTimeOffset end);

        void UpdateOrder(int orderid, int memberid, int employeeid, int shipmentid, DateTimeOffset orderdate, string shipmentaddress);
    }
}
