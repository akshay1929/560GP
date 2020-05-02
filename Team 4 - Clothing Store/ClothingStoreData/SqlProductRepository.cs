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

        public SqlProductRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Product GetProduct(int p)
        {
            var d = new GetProductIdNameDataDelegate(p);
            return executor.ExecuteReader(d);
        }

        public Product FetchProductQuantity(int quantity)
        {
            var d = new FetchProductQuantityDataDelegate(quantity);
            return executor.ExecuteReader(d);
        }

        public Product GetProductIdName(int producttypeid)
        {
            var d = new GetProductIdNameDataDelegate(producttypeid);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Product> RetrieveHighestRatings()
        {
            return executor.ExecuteReader(new RetrieveHighestRatingsDataDelegate());
        }


        public Product CreateProduct(string sku, string productname,
           int producttypeId, int quantity, string description, string price, string rating)
        {
            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(sku));

            if (string.IsNullOrWhiteSpace(productname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(productname));

            if (producttypeId < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(producttypeId));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            if (string.IsNullOrWhiteSpace(rating))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(rating));

            if (string.IsNullOrWhiteSpace(price))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(price));

            if (quantity < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(quantity));

            var d = new CreateProductDataDelegate(sku, productname, producttypeId, quantity, description, price, rating);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Product> RetrieveProducts()
        {
            return executor.ExecuteReader(new RetrieveProductsDataDelegate());
        }
    }
}
