using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class OrderLines
    {
        public int OrderLineID { get; }
        public int OrderID { get; }
        public int ProdcutID { get; }
        public int Quantity { get; }
        public float UnitPrice { get; }

        internal OrderLines (int olID, int oID, int pID, int q, float price)
        {
            OrderLineID = olID;
            OrderID = oID;
            ProdcutID = pID;
            Quantity = q;
            UnitPrice = price;
        }

    }
}
