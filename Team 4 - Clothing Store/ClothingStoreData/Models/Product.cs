using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Product
    {
        public int ProductID { get; }
        public string SKU { get; }
        public string ProductName { get; }
        public int ProductType { get; }
        public int Quantity { get; }
        public string Description { get; }
        public string Price { get; }
        public string Rating { get; }

        internal Product(int id, string sku, string productname,
           int producttype, int quantity, string description, string price, string rating)
        {
            ProductID = id;
            SKU = sku;
            ProductName = productname;
            ProductType = producttype;
            Quantity = quantity;
            Description = description;
            Price = price;
            Rating = rating;
        }

    }
}
