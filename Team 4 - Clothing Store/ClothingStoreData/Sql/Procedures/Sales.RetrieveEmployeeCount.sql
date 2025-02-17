CREATE OR ALTER PROCEDURE Sales.RetrieveEmployeeCount
   @GivenRole NVARCHAR(32)
AS

SELECT E.EmployeeRole, COUNT(EmployeeID) AS SumOfEmployees
FROM Sales.Employees E
WHERE E.EmployeeRole = @GivenRole
GROUP BY E.EmployeeRole
GO