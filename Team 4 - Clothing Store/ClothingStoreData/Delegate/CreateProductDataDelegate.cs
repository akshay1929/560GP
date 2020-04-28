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
        public readonly ProductType producttypeId;
        public readonly int quantity;
        public readonly string description;
        public readonly float price;
        public readonly float rating;

        public CreateProductDataDelegate(string sku, string productname,
           ProductType producttypeId, int quantity, string description, float price, float rating)
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

            p = command.Parameters.Add("Product Name", SqlDbType.NVarChar);
            p.Value = productname;

            p = command.Parameters.Add("Quantity", SqlDbType.Int);
            p.Value = quantity;

            p = command.Parameters.Add("Quantity", SqlDbType.NVarChar);
            p.Value = description;

            p = command.Parameters.Add("Quantity", SqlDbType.Float);
            p.Value = price;

            p = command.Parameters.Add("Quantity", SqlDbType.Float);
            p.Value = rating;
        }

        public override Product Translate(SqlCommand command)
        {
            return new Product(sku, productname, producttypeId, quantity, description, price, rating);
        }
    }
}
