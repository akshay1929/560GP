﻿using System.Collections.Generic;
using ClothingStoreData.Models;

namespace ClothingStoreData
{
    public interface IEmployeesRepository
    {
        IReadOnlyList<Employees> RetrieveEmployees();

        Employees FetchEmployeeSalary(int employeeid);

        Employees CreateEmployee(string email, string name, string role, int salary);

        void UpdateEmployeeRole(int employeeid, string email, string name, string employeerole, int salary);
    }
}
