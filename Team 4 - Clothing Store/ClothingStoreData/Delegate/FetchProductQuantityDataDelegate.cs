using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class FetchProductQuantityDataDelegate : DataReaderDelegate<IReadOnlyList<ProductQuantity>>
    {
        private readonly int producttypeid;

        public FetchProductQuantityDataDelegate(int producttypeid)
           : base("Product.FetchProductQuantity")
        {
            this.producttypeid = producttypeid;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenProductTypeID", producttypeid);
        }

        public override IReadOnlyList<ProductQuantity> Translate(SqlCommand command, IDataRowReader reader)
        {
            var products = new List<ProductQuantity>();

            while (reader.Read())
            {
               products.Add(new ProductQuantity(
                reader.GetString("ProductName"),
                reader.GetInt32("Quantity"),
                reader.GetString("Description")));
            }

            return products;
        }
    }
}
