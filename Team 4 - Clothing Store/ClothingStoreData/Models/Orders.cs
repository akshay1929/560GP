using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Orders
    {
        public int OrderID { get; }
        public int MemberID { get; }
        public int EmployeeID { get; }
        public int ShipmentID { get; }
        public DateTimeOffset OrderDate { get; }
        public DateTimeOffset StartDate { get; }
        public DateTimeOffset EndDate { get; } 
        public int TotalOrderCount { get; }
        public string ShipmentAddress { get; }

        internal Orders (int oID, int mID, int eID, int sID, DateTimeOffset date, string address)
        {
            OrderID = oID;
            MemberID = mID;
            EmployeeID = eID;
            ShipmentID = sID;
            OrderDate = date;
            ShipmentAddress = address;
        }

        internal Orders(DateTimeOffset startdate, DateTimeOffset enddate, int totalordercount)
        {
            StartDate = startdate;
            EndDate = enddate;
            TotalOrderCount = totalordercount;
        }

    }
}
