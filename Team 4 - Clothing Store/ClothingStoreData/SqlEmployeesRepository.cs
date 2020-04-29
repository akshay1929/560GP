using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;

namespace ClothingStoreData
{
    public class SqlEmployeesRepository : IEmployeesRepository
    {
        private readonly string connectionString;

        public SqlEmployeesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IReadOnlyList<Employees> RetrieveEmployees()
        {
            return executor.ExecuteReader(new RetrieveEmployeesDataDelegate());
        }

        public Employees FetchEmployeeSalary(int employeeid)
        {
            var d = new FetchEmployeeSalaryDataDelegate(employeeid);
            return executor.ExecuteReader(d);
        }
    }
}
