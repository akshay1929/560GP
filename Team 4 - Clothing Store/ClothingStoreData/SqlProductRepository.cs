using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;


namespace ClothingStoreData
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly SqlCommandExecutor executor;
        public Product GetProduct(ProductType p)
        {
            var d = new GetProductDataDelegate(p);
            return executor.ExecuteReader(d);
        }


        public Product CreateProduct(string sku, string productname,
           ProductType producttypeId, int quantity, string description, float price, float rating)
        {
            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(sku));

            if (string.IsNullOrWhiteSpace(productname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(productname));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            if (quantity < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(quantity));

            if (price < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(price));

            if (rating < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(rating));

            var d = new CreateProductDataDelegate(sku, productname, producttypeId, quantity, description, price, rating);
            return executor.ExecuteNonQuery(d);
        }
    }
}
