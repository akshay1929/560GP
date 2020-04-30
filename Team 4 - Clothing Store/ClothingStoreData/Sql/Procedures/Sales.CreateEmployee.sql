CREATE OR ALTER PROCEDURE Sales.CreateEmployee
   @Email NVARCHAR(128),
   @Name NVARCHAR(32),
   @EmployeeRole NVARCHAR(32),
   @Salary INT,
   @EmployeeID INT OUTPUT
AS

INSERT Employees(Email, [Name], EmployeeRole, Salary)
VALUES(@Email, @Name, @EmployeeRole, @Salary);

SET @EmployeeID = SCOPE_IDENTITY();
GO

