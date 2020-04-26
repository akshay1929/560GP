BEGIN
	CREATE TABLE Sales.Employees
	(
	    EmployeeID INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	    Email NVARCHAR(128) NOT NULL,
	    [Name] NVARCHAR(32) NOT NULL,
	    EmployeeRole NVARCHAR(32) NOT NULL,
	    Salary FLOAT NOT NULL 
	
	    UNIQUE
	    (
	        EmployeeID,
	        Email
	    )
	);
END