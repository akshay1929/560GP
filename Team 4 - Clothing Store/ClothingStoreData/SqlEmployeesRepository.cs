using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;

namespace ClothingStoreData
{
    public class SqlEmployeesRepository
    {
        private readonly SqlCommandExecutor executor;

        public Orders FetchEmployeeSalary(int employeeid)
        {
            var d = new GetOrderDataDelegate(employeeid);
            return executor.ExecuteReader(d);
        }
    }
}
