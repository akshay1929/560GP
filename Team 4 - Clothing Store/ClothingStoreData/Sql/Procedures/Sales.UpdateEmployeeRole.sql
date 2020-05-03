CREATE OR ALTER PROCEDURE Sales.UpdateEmployeeRole
   @GivenEmployeeID INT,
   @Email NVARCHAR(128),
   @Name NVARCHAR(32),
   @GivenEmployeeRole NVARCHAR(32),
   @Salary INT
AS

SELECT *
FROM Sales.Employees;

UPDATE Sales.Employees
SET   
	EmployeeID = @GivenEmployeeID,
	Email = @Email,
	[Name] = @Name,
	EmployeeRole = @GivenEmployeeRole,
	Salary = @Salary
WHERE EmployeeID = @GivenEmployeeID
GO
