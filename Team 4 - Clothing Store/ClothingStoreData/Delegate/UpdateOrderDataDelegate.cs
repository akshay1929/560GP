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
    internal class UpdateOrderDataDelegate : DataDelegate
    {
        public readonly int orderid;
        public readonly int memberid;
        public readonly int employeeid;
        public readonly int shipmentid;
        public readonly DateTimeOffset orderdate;
        public readonly string shipmentaddress;

        public UpdateOrderDataDelegate(int orderid, int memberid, int employeeid, int shipmentid,
           DateTimeOffset orderdate, string shipmentaddress)
           : base("Sales.UpdateOrder")
        {
            this.orderid = orderid;
            this.memberid = memberid;
            this.employeeid = employeeid;
            this.shipmentid = shipmentid;
            this.orderdate = orderdate;
            this.shipmentaddress = shipmentaddress;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenOrderID", orderid);
            command.Parameters.AddWithValue("GivenMemberID", memberid);
            command.Parameters.AddWithValue("GivenEmployeeID", employeeid);
            command.Parameters.AddWithValue("GivenShipmentID", shipmentid);
            command.Parameters.AddWithValue("GivenOrderDate", orderdate);
            command.Parameters.AddWithValue("GivenShipmentAddress", shipmentaddress);
        }
    }
}
