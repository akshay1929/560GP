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
        private readonly int productID;

        public RetrieveProductTypeCountDataDelegate(int s)
         : base("Product.RetrieveProductTypeCount")
        {
            this.productID = s;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ProductID", productID);
        }

        public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
        {
            var product = new List<Product>();

            while (reader.Read())
            {
                product.Add(new Product(
                    reader.GetInt32("ProductID"),
                    reader.GetString("SKU"),
                    reader.GetString("ProductName"),
                    reader.GetInt32("ProductType"),
                    reader.GetInt32("Quantity"),
                    reader.GetString("Description"),
                    reader.GetString("Price"),
                    reader.GetString("Rating")));
            }

            return product;
        }
    }
}
