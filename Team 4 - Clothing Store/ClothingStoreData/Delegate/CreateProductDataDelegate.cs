using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;


namespace ClothingStoreData.Delegate
{
    internal class CreateProductDataDelegate : NonQueryDataDelegate<Product>
    {
        public readonly string sku;
        public readonly string productname;
        public readonly int producttypeId;
        public readonly int quantity;
        public readonly string description;
        public readonly string price;
        public readonly string rating;

        public CreateProductDataDelegate(string sku, string productname,
           int producttypeId, int quantity, string description, string price, string rating)
           : base("Product.CreateProduct")
        {
            this.sku = sku;
            this.productname = productname;
            this.producttypeId = producttypeId;
            this.quantity = quantity;
            this.description = description;
            this.price = price;
            this.rating = rating;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("SKU", SqlDbType.NVarChar);
            p.Value = sku;

            p = command.Parameters.Add("ProductName", SqlDbType.NVarChar);
            p.Value = productname;

            p = command.Parameters.Add("ProductTypeId", SqlDbType.Int);
            p.Value = producttypeId;

            p = command.Parameters.Add("Quantity", SqlDbType.Int);
            p.Value = quantity;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = description;

            p = command.Parameters.Add("Price", SqlDbType.NVarChar);
            p.Value = price;

            p = command.Parameters.Add("Rating", SqlDbType.NVarChar);
            p.Value = rating;

            p = command.Parameters.Add("ProductID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Product Translate(SqlCommand command)
        {
            return new Product((int)command.Parameters["ProductID"].Value, sku, productname, producttypeId, quantity, description, price, rating);
        }
    }
}
