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
    class GetProductDataDelegate : DataReaderDelegate<Product>
    {
        private readonly ProductType productTypeID;
        public GetProductDataDelegate(ProductType p)
           : base("Product.GetProduct")
        {
            this.productTypeID = p;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ProductTypeID", productTypeID);
        }

        public override Product Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Product(
               reader.GetString("SKU"),
                reader.GetString("ProductName"),
               productTypeID,
               reader.GetInt32("Quantity"),
                reader.GetString("Description"),
                reader.GetFloat("Price"),
                reader.GetFloat("Rating")
               );

        }
    }
}
