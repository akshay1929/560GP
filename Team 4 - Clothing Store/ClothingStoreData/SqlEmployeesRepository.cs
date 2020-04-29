using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ClothingStoreData
{
    public class SqlEmployeesRepository : IEmployeesRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlEmployeesRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
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
