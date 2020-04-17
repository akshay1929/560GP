--CREATE SCHEMA Sales;
--GO

--CREATE SCHEMA Product;
--GO

--CREATE SCHEMA Warehouse;
--GO

--CREATE SCHEMA Users;
--GO

DROP TABLE IF EXISTS Sales.Employees;
DROP TABLE IF EXISTS Sales.Orders;
DROP TABLE IF EXISTS Sales.OrderLines;
DROP TABLE IF EXISTS Product.ProductType;
DROP TABLE IF EXISTS Product.Inventory;
DROP TABLE IF EXISTS Warehouse.Shipment;
DROP TABLE IF EXISTS Users.Member;

CREATE TABLE Users.Member
(
    MemberID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(128) NOT NULL,
    FirstName NVARCHAR(32) NOT NULL,
    LastName NVARCHAR(32) NOT NULL,
    Phone INT NOT NULL,
    BillingAddress NVARCHAR(128) NOT NULL,
    Points INT NOT NULL,
    JoinedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    BirthDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    [Status] NVARCHAR(32) NOT NULL,

    UNIQUE    
    (      
        Email,
        Phone   
    )
);

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

CREATE TABLE Warehouse.Shipment
(
    ShipmentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    ShipmentDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    ShipmentAddress NVARCHAR(128) NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

CREATE TABLE Sales.Orders
(
    OrderID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL FOREIGN KEY
        REFERENCES Users.Member(MemberID),
    EmployeeID INT NOT NULL FOREIGN KEY
        REFERENCES Sales.Employees(EmployeeID),
    ShipmentID INT NOT NULL FOREIGN KEY
        REFERENCES Warehouse.Shipment(ShipmentID),
    OrderDate DATETIMEOFFSET NOT NULL DEFAULT SYSDATETIMEOFFSET(),
    ShipmentAddress NVARCHAR(128) NOT NULL DEFAULT(SYSDATETIMEOFFSET())

    UNIQUE 
    (
        MemberID,
        EmployeeID
    )
);

CREATE TABLE Product.ProductType
(
	ProductTypeID INT NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(32) NOT NULL
);

CREATE TABLE Product.Inventory
(
	ProductID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	SKU INT NOT NULL UNIQUE,
	ProductName NVARCHAR(32) NOT NULL,
    ProductTypeID INT NOT NULL FOREIGN KEY
        REFERENCES Product.ProductType(ProductTypeID),
	Quantity INT NOT NULL,
    [Description] NVARCHAR(128) NOT NULL,
    Price FLOAT NOT NULL,
	Rating FLOAT NOT NULL  
);

CREATE TABLE Sales.OrderLines
(
    OrderLineID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL FOREIGN KEY
        REFERENCES Sales.Orders(OrderID),
    ProductID INT NOT NULL FOREIGN KEY
        REFERENCES Product.Inventory(ProductID),
    Quantity INT NOT NULL,
    UnitPrice FLOAT NOT NULL
);



