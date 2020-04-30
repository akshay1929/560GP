using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class FetchProductQuantityDataDelegate : DataReaderDelegate<Product>
    {
        private readonly int quantity;

        public FetchProductQuantityDataDelegate(int quantity)
           : base("Product.FetchProductQuantity")
        {
            this.quantity = quantity;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Quantity", quantity);
        }

        public override Product Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Product(
               reader.GetString("SKU"),
               reader.GetString("ProductName"),
               (ProductType)reader.GetByte("ProductType"),
               quantity,
               reader.GetString("Description"),
               reader.GetFloat("Price"),
               reader.GetString("Rating"));
        }
    }
}
