-- Update Member Procedure --
CREATE OR ALTER PROCEDURE Users.UpdateMember
   @GivenMemberID INT,
   @GivenEmail NVARCHAR(128),
   @GivenFirstName NVARCHAR(32),
   @GivenLastName NVARCHAR(32),
   @GivenPhone NVARCHAR(32),
   @GivenBillingAddress NVARCHAR(128),
   @GivenPoints INT,
   @GivenJoinedOn DATETIMEOFFSET,
   @GivenBirthDate DATETIMEOFFSET,
   @GivenStatus NVARCHAR(32)
AS

SELECT *
FROM Users.Member;

UPDATE Users.Member
SET   
	Email = @GivenEmail,
	FirstName = @GivenFirstName,
	LastName = @GivenLastName,
	Phone = @GivenPhone,
	BillingAddress = @GivenBillingAddress,
	Points = @GivenPoints,
	JoinedOn = @GivenJoinedOn,
	BirthDate = @GivenBirthDate,
	[Status] = @GivenStatus
WHERE MemberID = @GivenMemberID
GO

-- Update Employee Role Procedure --
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
	Email = @GivenEmail,
	[Name] = @GivenName,
	EmployeeRole = @GivenEmployeeRole,
	Salary = @GivenSalary
WHERE EmployeeID = @GivenEmployeeID
GO

-- Update Product Procedure --
CREATE OR ALTER PROCEDURE Product.UpdateProduct
   @GivenProductID INT,
   @GivenSKU NVARCHAR(32),
   @GivenProductName NVARCHAR(64),
   @GivenProductTypeID INT,
   @GivenQuantity INT,
   @GivenDescription NVARCHAR(MAX),
   @GivenPrice Float,
   @GivenRating NVARCHAR(32)
AS

SELECT *
FROM Product;

UPDATE Product
SET   
	SKU = @GivenSKU,
	ProductName = @GivenProductName,
	ProductTypeID = @GivenProductTypeID,
	Quantity = @GivenQuantity,
	[Description] = @GivenDescription,
	Price = @GivenPrice,
	Rating = @GivenRating

WHERE ProductID = @GivenProductID
GO

-- Update Order Procedure --
CREATE OR ALTER PROCEDURE Sales.UpdateOrder
   @GivenOrderID INT,
   @GivenMemberID INT,
   @GivenEmployeeID INT,
   @GivenShipmentID INT,
   @GivenOrderDate DATETIMEOFFSET,
   @GivenShipmentAddress NVARCHAR(128)
AS

SELECT *
FROM Sales.Orders;

UPDATE Sales.Orders
SET   
	MemberID = @GivenMemberID,
	EmployeeID = @GivenEmployeeID,
	ShipmentID = @GivenShipmentID,
	OrderDate = @GivenOrderDate,
	ShipmentAddress = @GivenShipmentAddress
WHERE OrderID = @GivenOrderID
GO

-- Create Shipment Procedure --
CREATE OR ALTER PROCEDURE Warehouse.CreateShipment
   @ShipmentDate DATETIMEOFFSET,
   @ShipmentAddress NVARCHAR(128),
   @ShipmentID INT OUTPUT
AS

INSERT Warehouse.Shipment(ShipmentDate, ShipmentAddress)
VALUES(@ShipmentDate, @ShipmentAddress);

SET @ShipmentID = SCOPE_IDENTITY();
GO

-- Create Product Procedure --
CREATE OR ALTER PROCEDURE Product.CreateProduct
   @SKU NVARCHAR(32),
   @ProductName NVARCHAR(64),
   @ProductTypeId INT,
   @Quantity INT,
   @Description NVARCHAR(MAX),
   @Price Float,
   @Rating Float,
   @ProductId INT OUTPUT
AS

INSERT Product(SKU, ProductName, ProductTypeId, Quantity, [Description], Price, Rating)
VALUES(@SKU, @ProductName, @ProductTypeId, @Quantity, @Description, @Price, @Rating);

SET @ProductId = SCOPE_IDENTITY();
GO

-- Create Employee Procedure -- 
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

-- Create Member Procedure --
CREATE OR ALTER PROCEDURE Users.CreateMember
   @Email NVARCHAR(128),
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Phone NVARCHAR(32),
   @BillingAddress NVARCHAR(128),
   @Points INT,
   @JoinedOn DATETIMEOFFSET,
   @BirthDate DATETIMEOFFSET,
   @Status NVARCHAR(32),
   @MemberId INT OUTPUT
AS

INSERT Member(Email, FirstName, LastName, Phone, BillingAddress, Points, JoinedOn, BirthDate, [Status])
VALUES(@Email, @FirstName, @LastName, @Phone, @BillingAddress, @Points, @JoinedOn, @BirthDate, @Status);

SET @MemberId = SCOPE_IDENTITY();
GO

-- Retrieve Employees Procedure --
CREATE OR ALTER PROCEDURE Sales.RetrieveEmployees
AS

SELECT *
FROM Sales.Employees;
GO

-- Retrieve Members Procedure --
CREATE OR ALTER PROCEDURE Users.RetrieveMembers
AS

SELECT *
FROM Users.Member M;
GO

-- Retrieve Orders Procedure --
CREATE OR ALTER PROCEDURE Sales.RetrieveOrders
AS

SELECT *
FROM Sales.Orders O;
GO

-- Retrieve Products Procedure --
CREATE OR ALTER PROCEDURE Product.RetrieveProducts
AS

SELECT *
FROM Product P
	LEFT JOIN Product.ProductType PT ON PT.ProductTypeID = P.ProductTypeID;
GO

-- Retrieve Shipments Procedure --
CREATE OR ALTER PROCEDURE Warehouse.RetrieveShipments
AS

SELECT *
FROM Warehouse.Shipment S;
GO

-- Retrieve Order Count Date Procedure --
CREATE OR ALTER PROCEDURE Sales.RetrieveOrderCountDate
 @StartDate DATETIMEOFFSET,
 @EndDate DATETIMEOFFSET
AS

SELECT 
	 @StartDate AS StartDate,
	 @EndDate AS EndDate,
     COUNT(O.OrderID) AS TotalOrders
FROM 
	Sales.Orders O
WHERE
	O.OrderDate BETWEEN @StartDate AND @EndDate
GO

-- Retrieve Product Highest Ratings Procedure --
CREATE OR ALTER PROCEDURE Product.RetrieveHighestRatings
AS

SELECT *
FROM 
	Product P
ORDER BY 
	P.Rating DESC, P.ProductName ASC
GO

-- Retrieve Product Type Count Procedure --
CREATE OR ALTER PROCEDURE Product.RetrieveProductTypeCount
AS

SELECT PT.[Name], COUNT(O.OrderID) AS OrdersPlaced, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
	INNER JOIN Sales.OrderLines OL ON OL.ProductID = P.ProductID
	INNER JOIN Sales.Orders O ON O.OrderID = OL.OrderID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(O.OrderID) DESC, P.SKU DESC
GO

-- Retrieve Employee Count Procedure --
CREATE OR ALTER PROCEDURE Sales.RetrieveEmployeeCount
   @GivenRole NVARCHAR(32)
AS

SELECT E.EmployeeRole, COUNT(EmployeeID) AS SumOfEmployees
FROM Sales.Employees E
WHERE E.EmployeeRole = @GivenRole
GROUP BY E.EmployeeRole
GO

-- Retrieve Member Points Procedure --
CREATE OR ALTER PROCEDURE Users.RetrieveMemberPoints
AS

SELECT *
FROM 
	Users.Member M
ORDER BY 
	M.Points DESC
GO

-- Fetch Product Quantity Procedure --
CREATE OR ALTER PROCEDURE Product.FetchProductQuantity
@GivenProductTypeID INT
AS

SELECT 
	P.ProductName, P.[Description], P.Quantity
FROM 
	Product P
WHERE 
	P.ProductTypeID = @GivenProductTypeID
GO

-- Fetch Employee Salary Procedure --
CREATE OR ALTER PROCEDURE Sales.FetchEmployeeSalary
   @GivenEmployeeID INT
AS

SELECT *
FROM 
	Sales.Employees E
WHERE 
	E.EmployeeID = @GivenEmployeeID
GO

-- Fetch Member Status Procedure --
CREATE OR ALTER PROCEDURE Users.FetchMemberStatus
   @GivenMemberid INT
AS

SELECT M.MemberID, M.FirstName, M.LastName, M.Points, M.[Status]
FROM Users.Member M
WHERE M.MemberID = @GivenMemberid
GROUP BY M.MemberID, M.[Status], M.FirstName, M.LastName, M.Points
GO

-- Get Product Name Procedure. Name Off --
CREATE OR ALTER PROCEDURE Product.GetOrderIdName
   @GivenOrderID INT
AS

SELECT 
	OL.OrderID, 
	P.ProductName, 
	OL.Quantity 
FROM 
	Sales.OrderLines OL
		INNER JOIN Product P ON P.ProductID = OL.ProductID
WHERE 
	OL.OrderID = @GivenOrderID
GO

-- Get Product ID Name Procedure --
CREATE OR ALTER PROCEDURE Product.GetProductIdName
   @GivenProductTypeID INT
AS

SELECT 
	P.ProductTypeID,
	P.ProductName, 
	P.Quantity
FROM 
	Product P
WHERE 
	P.ProductTypeID = @GivenProductTypeID
GO

-- Get MemberId Procedure --
CREATE OR ALTER PROCEDURE Users.GetMemberId
   @GivenEmail NVARCHAR(128)
AS

SELECT *
FROM Users.Member M
WHERE M.Email = @GivenEmail
GO

-- Get Shipment Address Procedure --
CREATE OR ALTER PROCEDURE Warehouse.GetShipmentAddress
   @GivenAddress NVARCHAR(128)
AS

SELECT S.ShipmentID, S.ShipmentAddress, O.OrderID
FROM Sales.Orders O
    INNER JOIN Warehouse.Shipment S ON S.ShipmentAddress = O.ShipmentAddress
WHERE S.ShipmentAddress = @GivenAddress
GROUP BY S.ShipmentID, S.ShipmentAddress, O.OrderID
ORDER BY S.ShipmentID ASC
GO

-- Report #1 Query --
SELECT 
	P.ProductId, 
	P.SKU, P.ProductName, 
	P.Quantity,
	P.[Description], 
	P.Price, 
	P.Rating
FROM 
	Product P
ORDER BY 
	P.Rating DESC

-- Report #2 Query --
SELECT 
	M.FirstName, 
	M.LastName, 
	M.Points, 
	M.[Status]
FROM 
	Users.Member M
ORDER BY 
	M.Points DESC

-- Report #3 Query --
SELECT 
    COUNT(O.OrderID) AS TotalOrders,
    SUM(IIF(MONTH(O.OrderDate) = 01, 1, 0)) AS JanOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 02, 1, 0)) AS FebOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 03, 1, 0)) AS MarOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 04, 1, 0)) AS AprilOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 05, 1, 0)) AS MayOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 06, 1, 0)) AS JuneOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 07, 1, 0)) AS JulyOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 08, 1, 0)) AS AugOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 09, 1, 0)) AS SeptOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 10, 1, 0)) AS OctOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 11, 1, 0)) AS NovOrderPlaced,
    SUM(IIF(MONTH(O.OrderDate) = 12, 1, 0)) AS DecOrderPlaced
FROM 
	Sales.Orders O


-- Report #4 Query --
SELECT PT.[Name], COUNT(P.ProductID) AS OrderCount, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(P.ProductID) DESC, P.SKU DESC


-- Question #1 Query--
DECLARE @GivenEmail NVARCHAR(128);
SET @GivenEmail = 'ilene.eroman@hotmail.com';

SELECT
	M.MemberID,
	M.Email,
	M.FirstName,
	M.LastName
FROM
	Users.Member M
WHERE
	M.Email = @GivenEmail

-- Question #2 Query --
DECLARE @GivenEmployeeID INT;
SET @GivenEmployeeID = 5;

SELECT
	E.EmployeeID,
	E.Salary
FROM
	Sales.Employees E
WHERE
	E.EmployeeID = @GivenEmployeeID

-- Question #3 Query --
DECLARE @GivenProductID INT;
SET @GivenProductID = 1;

SELECT
	P.ProductID,
	P.Quantity
FROM
	Product P
WHERE
	P.ProductID = @GivenProductID

-- Question #4 Query --
DECLARE @Memberid INT --= ''
SELECT M.MemberID, M.Status
FROM Users.Member M
WHERE M.MemberID = @Memberid
GROUP BY M.MemberID, M.Status
ORDER BY M.MemberID ASC

-- Question #5 Query --
DECLARE @Address NVARCHAR(128) --= ''
SELECT S.ShipmentID, S.ShipmentAddress, O.OrderID
FROM Sales.Orders O
    INNER JOIN Warehouse.Shipment S ON S.ShipmentAddress = O.ShipmentAddress
WHERE S.ShipmentAddress = @Address
GROUP BY S.ShipmentID, S.ShipmentAddress, O.OrderID
ORDER BY S.ShipmentID ASC

-- Question #6 Query --
DECLARE @Role NVARCHAR(32) --= ''
SELECT E.EmployeeRole, COUNT(EmployeeID) AS SumOfEmployees
FROM Sales.Employees E
WHERE E.EmployeeRole = @Role
GROUP BY E.EmployeeRole

-- Question #7  Query --
DECLARE @GivenProductTypeID INT;
SET @GivenProductTypeID = 1;

SELECT 
	P.ProductTypeID,
	P.ProductName, 
	P.Quantity
FROM 
	Product P
WHERE 
	P.ProductTypeID = @GivenProductTypeID

-- Question #8 Query --
DECLARE @GivenOrderID INT;
SET @GivenOrderID = 2;

SELECT 
	OL.OrderID, 
	P.ProductName, 
	OL.Quantity 
FROM 
	Sales.OrderLines OL
		INNER JOIN Product P ON P.ProductID = OL.ProductID
WHERE 
	OL.OrderID = @GivenOrderID
