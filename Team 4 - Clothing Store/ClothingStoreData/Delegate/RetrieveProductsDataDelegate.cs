using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class RetrieveProductsDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
    {

        public RetrieveProductsDataDelegate()
           : base("Product.RetrieveProducts")
        {
        }

        public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
        {
            var products = new List<Product>();

            while (reader.Read())
            {
                products.Add(new Product(
                    reader.GetInt32("ProductID"),
                    reader.GetString("SKU"),
                    reader.GetString("ProductName"),
                    reader.GetInt32("ProductTypeID"),
                    reader.GetInt32("Quantity"),
                    reader.GetString("Description"),
                    reader.GetString("Price"),
                    reader.GetString("Rating")));
            }

            return products;
        }
    }
}
