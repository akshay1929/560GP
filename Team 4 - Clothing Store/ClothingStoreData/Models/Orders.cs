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

       

    }
}
