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

        public IReadOnlyList<ProductQuantity> FetchProductQuantity(int producttypeid)
        {
            return executor.ExecuteReader(new FetchProductQuantityDataDelegate(producttypeid));
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

        public IReadOnlyList<ProductTypeCount> RetrieveProductCount()
        {
            return executor.ExecuteReader(new RetrieveProductTypeCountDataDelegate());
        }

        public void UpdateProduct(int productid, string sku, string productname, int producttypeid, int quantity, string description, string price, string rating)
        {
            if (sku == null)
                throw new ArgumentNullException(nameof(sku));

            if (description == null)
                throw new ArgumentNullException(nameof(description));

            if (rating == null)
                throw new ArgumentNullException(nameof(rating));

            if (price == null)
                throw new ArgumentNullException(nameof(price));

            var d = new UpdateProductDataDelegate(productid, sku, productname, producttypeid, quantity, description, price, rating);
            executor.ExecuteNonQuery(d);
        }
    }
}
