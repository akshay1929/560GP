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
    internal class UpdateProductDataDelegate : DataDelegate
    {
        public readonly int productid;
        public readonly string sku;
        public readonly string productname;
        public readonly int producttypeid;
        public readonly int quantity;
        public readonly string description;
        public readonly float price;
        public readonly string rating;

        public UpdateProductDataDelegate(int productid, string sku, string productname, int producttypeid, int quantity,
           string description, float price, string rating)
           : base("Sales.UpdateEmployeeRole")
        {
            this.productid = productid;
            this.sku = sku;
            this.productname = productname;
            this.producttypeid = producttypeid;
            this.quantity = quantity;
            this.description = description;
            this.price = price;
            this.rating = rating;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenProductID", productid);
            command.Parameters.AddWithValue("GivenSKU", sku);
            command.Parameters.AddWithValue("GivenProductName", productname);
            command.Parameters.AddWithValue("GivenProductTypeID", producttypeid);
            command.Parameters.AddWithValue("GivenQuantity", quantity);
            command.Parameters.AddWithValue("GivenDescription", description);
            command.Parameters.AddWithValue("GivenPrice", price);
            command.Parameters.AddWithValue("GivenRating", rating);
        }
    }
}
