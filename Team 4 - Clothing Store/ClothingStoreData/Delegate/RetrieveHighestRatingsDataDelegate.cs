using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class RetrieveHighestRatingsDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
    {

        public RetrieveHighestRatingsDataDelegate()
           : base("Product.RetrieveHighestRatings")
        {
        }

        public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
        {
            var ratings = new List<Product>();

            while (reader.Read())
            {
                ratings.Add(new Product(
                    reader.GetInt32("ProductID"),
                    reader.GetString("SKU"),
                    reader.GetString("ProductName"),
                    reader.GetInt32("ProductType"),
                    reader.GetInt32("Quantity"),
                    reader.GetString("Description"),
                    reader.GetString("Price"),
                    reader.GetString("Rating")));
            }

            return ratings;
        }
    }
}
