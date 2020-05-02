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
    public class RetrieveProductTypeCountDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
    {
       

        public RetrieveProductTypeCountDataDelegate()
         : base("Product.RetrieveProductTypeCount")
        {
            
        }


        public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
        {
            var count = new List<Product>();

            while (reader.Read())
            {
                count.Add(new Product(
                    
                    reader.GetString("SKU"),
                     reader.GetInt32("Count"),
                    reader.GetString("ProductName")
                   
                    ));
            }

            return count;
        }
    }
}
