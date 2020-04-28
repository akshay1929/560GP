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
                    reader.GetString("SKU"),
                    reader.GetString("ProductName"),
                    (ProductType)reader.GetByte("ProductType"),
                    reader.GetInt32("Quantity"),
                    reader.GetString("Description"),
                    reader.GetFloat("Price"),
                    reader.GetFloat("Rating")));
            }

            return ratings;
        }
    }
}
