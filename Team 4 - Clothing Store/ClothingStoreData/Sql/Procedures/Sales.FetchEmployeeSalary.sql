CREATE OR ALTER PROCEDURE Sales.FetchEmployeeSalary
   @GivenEmployeeID INT
AS

SELECT 
	E.[Name],
	E.Salary
FROM 
	Sales.Employees E
WHERE 
	E.EmployeeID = @GivenEmployeeID
GO
