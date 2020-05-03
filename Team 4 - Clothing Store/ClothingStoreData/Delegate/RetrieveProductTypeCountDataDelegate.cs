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
   // check implementation
    public class RetrieveProductTypeCountDataDelegate : DataReaderDelegate<IReadOnlyList<ProductTypeCount>>
    {

        public RetrieveProductTypeCountDataDelegate()
         : base("Product.RetrieveProductTypeCount")
        {
            
        }


        public override IReadOnlyList<ProductTypeCount> Translate(SqlCommand command, IDataRowReader reader)
        {
            var count = new List<ProductTypeCount>();

            while (reader.Read())
            {
                count.Add(new ProductTypeCount(
                    reader.GetString("SKU"),
                    reader.GetString("Name"),
                    reader.GetInt32("OrdersPlaced")
                    ));
            }

            return count;
        }
    }
}
