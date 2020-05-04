CREATE OR ALTER PROCEDURE Sales.UpdateEmployeeRole
   @GivenEmployeeID INT,
   @GivenEmail NVARCHAR(128),
   @GivenName NVARCHAR(32),
   @GivenEmployeeRole NVARCHAR(32),
   @GivenSalary INT
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
