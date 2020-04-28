using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;

namespace ClothingStoreData
{
    public class SqlOrderRepository
    {
        private readonly SqlCommandExecutor executor;
        public Orders GetProduct(int id)
        {
            var d = new GetOrderDataDelegate(id);
            return executor.ExecuteReader(d);
        }
    }
}
