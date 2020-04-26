DECLARE @EmployeesStaging TABLE
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

INSERT @EmployeeStaging(Email, [Name], EmployeeRole, Salary)
VALUES
    (N'felis.adipiscing@semperet.edu', N'Jonah', N'Manager', 4588.07), 
    (N'Cras@ante.com', N'Axel', N'Sales ', 5913.55), 
    (N'Proin.eget@egetlaoreet.co.uk', N'Xenos', N'Marketing', 7578.33), 
    (N'turpis.In.condimentum@Fuscemollis.co.uk', N'Tanek', N'Warehouse', 9444.51), 
    (N'ligula.eu@accumsansed.org', N'Wesley', N'Shipping', 7459.37), 
    (N'Vivamus@Aliquamnecenim.com', N'Mannix', N'Purchase', 8294.34), 
    (N'a.mi@infelisNulla.co.uk', N'Ryder', N'IT', 1444.54), 
    (N'Aliquam.erat@nuncullamcorpereu.net', N'Tiger', N'Web Development', 3492.11), 
    (N'orci.consectetuer.euismod@vitae.org', N'Victor', N'Customer Care', 1933.25), 
    (N'mauris.ipsum.porta@urnaUttincidunt.co.uk', N'Victor', N'Packaging ', 1210.9), 
    (N'Duis.gravida@auctor.com', N'Linus', N'Delivery', 1305.22), 
    (N'Aenean.gravida@leoMorbineque.org', N'Jacob', N'HR', 1198.91), 
    (N'orci.Phasellus.dapibus@Fuscediam.ca', N'Arthur', N'Quality Control', 4830.47), 
    (N'elit.Nulla.facilisi@pedeCumsociis.ca', N'Duncan', N'Security', 5416.07), 
    (N'a.arcu@eratnequenon.net', N'Noble', N'Graphical', 7860.37); 