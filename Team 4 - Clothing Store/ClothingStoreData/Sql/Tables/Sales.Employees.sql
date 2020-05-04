IF OBJECT_ID(N'Sales.Employees') IS NULL
BEGIN
	CREATE TABLE Sales.Employees
	(
	    EmployeeID INT NOT NULL IDENTITY (1,1),
	    Email NVARCHAR(128) NOT NULL,
	    [Name] NVARCHAR(32) NOT NULL,
	    EmployeeRole NVARCHAR(32) NOT NULL,
	    Salary INT NOT NULL 
	
	     CONSTRAINT [PK_Sales_Employees_EmployeeId] PRIMARY KEY CLUSTERED
      (
         EmployeeID ASC
      )
	);
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Sales.Employees')
         AND kc.[name] = N'UK_Sales_Employees_Email'
   )
BEGIN
   ALTER TABLE Sales.Employees
   ADD CONSTRAINT [UK_Sales_Employees_Email] UNIQUE NONCLUSTERED
   (
      Email ASC
   )
END;