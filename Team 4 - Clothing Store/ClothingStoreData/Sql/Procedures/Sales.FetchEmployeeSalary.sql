CREATE OR ALTER PROCEDURE Sales.FetchEmployeeSalary
   @GivenEmployeeID INT
AS

SELECT *
FROM 
	Sales.Employees E
WHERE 
	E.EmployeeID = @GivenEmployeeID
GO
