using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class ProductTypeCount
    {
        public string SKU { get; }
        public string Name { get; }
        public int OrdersPlaced { get; }

        internal ProductTypeCount(string sku, string producttypename, int ordersplaced)
        {
            SKU = sku;
            Name = producttypename;
            OrdersPlaced = ordersplaced;
        }
    }
}
