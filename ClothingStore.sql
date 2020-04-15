--CREATE SCHEMA Sales;
--GO

--CREATE SCHEMA Product;
--GO

DROP TABLE IF EXISTS Sales.Employees;
DROP TABLE IF EXISTS Sales.Orders;
DROP TABLE IF EXISTS Sales.OrderLines;
DROP TABLE IF EXISTS Product.ProductType;
DROP TABLE IF EXISTS Product.Inventory;

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
)

CREATE TABLE Sales.Orders
(
    OrderID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL,
    EmployeeID INT NOT NULL,
    OrderDate DATETIMEOFFSET NOT NULL DEFAULT SYSDATETIMEOFFSET()

    UNIQUE 
    (
        MemberID,
        EmployeeID
    )
)

CREATE TABLE Sales.OrderLines
(
    OrderLineID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL FOREIGN KEY
        REFERENCES Sales.Orders(OrderID),
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice FLOAT NOT NULL
)

CREATE TABLE Product.Inventory
(
	ProductID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	SKU INT NOT NULL UNIQUE,
	ProductName NVARCHAR(32) NOT NULL,
	Quantity INT NOT NULL
);

CREATE TABLE Product.ProductType
(
	ProductType NVARCHAR(32) NOT NULL PRIMARY KEY,
	ProductID INT NOT NULL FOREIGN KEY
		REFERENCES Product.Inventory(ProductID),
	[Description] NVARCHAR(128) NOT NULL,
	Price FLOAT NOT NULL,
	Rating FLOAT NOT NULL
);