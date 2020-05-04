using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;

namespace ClothingStoreData
{
    public interface IProductRepository
    {

        Product GetProduct(int id);

        IReadOnlyList<ProductQuantity> FetchProductQuantity(int producttypeid);

        IReadOnlyList<Product> RetrieveHighestRatings();
        IReadOnlyList<Product> RetrieveProducts();
        IReadOnlyList<ProductTypeCount> RetrieveProductCount();

        Product GetProductIdName(int producttype);

        void UpdateProduct(int productid, string sku, string productname, int producttypeid, int quantity, string description, string price, string rating);

        Product CreateProduct(string sku, string productname,
           int producttypeId, int quantity, string description, string price, string rating);
    }
}
