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
   
    public class GetProductTypeCountDataDelegate : DataReaderDelegate<Product>
    {
        private readonly int productID;
        public GetProductTypeCountDataDelegate(int s)
         : base("Product.GetProductTypeCount")
        {
            this.productID = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ProductID", productID);
        }

        public override Product Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Product(
               reader.GetString("SKU"),
               reader.GetString("ProductName"),
               (ProductType)reader.GetByte("ProductType"),
               reader.GetInt32("Quantity"),
               reader.GetString("Description"),
               reader.GetFloat("Price"),
               reader.GetFloat("Rating")
               );
        }
    }
}
