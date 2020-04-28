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

        Product GetProduct(ProductType id);
        Product CreateProduct(string sku, string productname,
           ProductType producttypeId, int quantity, string description, float price, float rating);
    }
}
