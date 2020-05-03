using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using ClothingStoreData.Models;
using System.Data.SqlClient;


namespace ClothingStoreData.Delegate
{
    class RetrieveOrderCountDateDataDelegate : DataReaderDelegate<Orders>
    {
        private readonly DateTimeOffset startdate;
        private readonly DateTimeOffset enddate;

        public RetrieveOrderCountDateDataDelegate(DateTimeOffset startdate, DateTimeOffset enddate)
           : base("Sales.RetrieveOrderCountDate")
        {
            this.startdate = startdate;
            this.enddate = enddate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StartDate", startdate);
            command.Parameters.AddWithValue("EndDate", enddate);
        }

        public override Orders Translate(SqlCommand command, IDataRowReader reader)
        {

            if (!reader.Read())
                return null;

            return new Orders(
               reader.GetDateTimeOffset("StartDate"),
               reader.GetDateTimeOffset("EndDate"),
               reader.GetInt32("TotalOrders")
               );
        }
    }
}
