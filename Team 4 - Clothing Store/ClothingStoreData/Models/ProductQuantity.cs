using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class ProductQuantity
    {
        public string ProductName { get; }
        public int Quantity { get; }
        public string Description { get; }

        internal ProductQuantity(string productname, int quantity, string description)
        {
            ProductName = productname;
            Quantity = quantity;
            Description = description;
        }
    }
}
