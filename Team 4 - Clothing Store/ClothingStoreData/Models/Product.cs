using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Product
    {
        public string SKU { get; }
        public string ProductName { get; }
        public ProductType ProductType { get; }
        public int Quantity { get; }
        public string Description { get; }
        public float Price { get; }
        public float Rating { get; }

        internal Product(string sku, string productname,
           ProductType producttype, int quantity, string description, float price, float rating)
        {
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
