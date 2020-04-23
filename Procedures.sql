/* Report #1 */
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

/* Report #2 */
SELECT 
	M.FirstName, 
	M.LastName, 
	M.Points, 
	M.[Status]
FROM 
	Users.Member M
ORDER BY 
	M.Points DESC

/* Report #3 */
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


-- Report 4:
SELECT PT.[Name], COUNT(P.ProductID) AS OrderCount, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(P.ProductID) DESC, P.SKU DESC


/* Question #1 */
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

/* Question #2 */
DECLARE @GivenEmployeeID INT;
SET @GivenEmployeeID = 5;

SELECT
	E.EmployeeID,
	E.Salary
FROM
	Sales.Employees E
WHERE
	E.EmployeeID = @GivenEmployeeID

/* Question #3 */
DECLARE @GivenProductID INT;
SET @GivenProductID = 1;

SELECT
	P.ProductID,
	P.Quantity
FROM
	Product P
WHERE
	P.ProductID = @GivenProductID

-- Question 4:
DECLARE @Memberid INT --= ''
SELECT M.MemberID, M.Status
FROM Users.Member M
WHERE M.MemberID = @Memberid
GROUP BY M.MemberID, M.Status
ORDER BY M.MemberID ASC

-- Question 5:
DECLARE @Address NVARCHAR(128) --= ''
SELECT S.ShipmentID, S.ShipmentAddress, O.OrderID
FROM Sales.Orders O
    INNER JOIN Warehouse.Shipment S ON S.ShipmentAddress = O.ShipmentAddress
WHERE S.ShipmentAddress = @Address
GROUP BY S.ShipmentID, S.ShipmentAddress, O.OrderID
ORDER BY S.ShipmentID ASC

-- Question 6:
DECLARE @Role NVARCHAR(32) --= ''
SELECT E.EmployeeRole, COUNT(EmployeeID) AS SumOfEmployees
FROM Sales.Employees E
WHERE E.EmployeeRole = @Role
GROUP BY E.EmployeeRole

/* Question #7 */
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

/* Question #8 */
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
