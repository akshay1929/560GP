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

        public Employees CreateEmployee(string email, string name, string role, int salary)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(role));

            if (salary < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(salary));

            var d = new CreateEmployeeDataDelegate(email, name, role, salary);
            return executor.ExecuteNonQuery(d);
        }


        public Employees FetchEmployeeSalary(int employeeid)
        {
            var d = new FetchEmployeeSalaryDataDelegate(employeeid);
            return executor.ExecuteReader(d);
        }
    }
}
