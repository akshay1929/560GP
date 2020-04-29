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
        private readonly string connectionString;

        public SqlEmployeesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IReadOnlyList<Employees> RetrieveEmployees()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Employees.RetrieveEmployees", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateEmployees(reader);
                }
            }
        }

        public Employees FetchEmployeeSalary(int employeeid)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Employees.FetchPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("EmployeeID", employeeid);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var employee = TranslateEmployee(reader);

                        if (employee == null)
                            throw new RecordNotFoundException(employeeid.ToString());

                        return employee;
                    }
                }
            }
        }

        private Employees TranslateEmployee(SqlDataReader reader)
        {

            var employeeidOrdinal = reader.GetOrdinal("EmployeeID");
            var emailOrdinal = reader.GetOrdinal("Email");
            var nameOrdinal = reader.GetOrdinal("Name");
            var roleOrdinal = reader.GetOrdinal("EmployeeRole");
            var salaryOrdinal = reader.GetOrdinal("Salary");

            if (!reader.Read())
                return null;
            return new Employees(
                   reader.GetInt32(employeeidOrdinal),
                   reader.GetString(emailOrdinal),
                   reader.GetString(nameOrdinal),
                   reader.GetString(roleOrdinal),
                    reader.GetInt32(salaryOrdinal)));
            }

        private IReadOnlyList<Employees> TranslateEmployees(SqlDataReader reader)
        {
            var employee = new List<Employees>();

            var employeeidOrdinal = reader.GetOrdinal("EmployeeID");
            var emailOrdinal = reader.GetOrdinal("Email");
            var nameOrdinal = reader.GetOrdinal("Name");
            var roleOrdinal = reader.GetOrdinal("EmployeeRole");
            var salaryOrdinal = reader.GetOrdinal("Salary");

            while (reader.Read())
            {
                employee.Add(new Employees(
                   reader.GetInt32(employeeidOrdinal),
                   reader.GetString(emailOrdinal),
                   reader.GetString(nameOrdinal),
                   reader.GetString(roleOrdinal),
                    reader.GetInt32(salaryOrdinal)));
            }

            return employee;
        }
    }
}
