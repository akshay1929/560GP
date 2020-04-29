CREATE OR ALTER PROCEDURE Sales.RetrieveEmployees
AS

SELECT E.EmployeeID, E.Email, E.[Name], E.EmployeeRole, E.Salary
FROM Sales.Employees E;
GO
