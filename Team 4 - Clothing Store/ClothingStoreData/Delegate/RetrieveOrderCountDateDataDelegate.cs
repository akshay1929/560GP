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
        private readonly DateTimeOffset start;
        private readonly DateTimeOffset end;

        public RetrieveOrderCountDateDataDelegate(DateTimeOffset s, DateTimeOffset e)
           : base("Sales.RetrieveOrderCountDate")
        {
            start = s;
            end = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StartDate", start);
            command.Parameters.AddWithValue("EndDate", end);
        }

        public override Orders Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Orders(
               reader.GetInt32("TotalOrders"))
               
               ;
        }
    }
}
