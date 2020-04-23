/*Report #2*/
SELECT M.FirstName, M.LastName, M.Points, M.[Status]
FROM Users.Member M
ORDER BY M.Points DESC

/*Report #3*/
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
FROM Sales.Orders O

/*Question #7*/
SELECT P.ProductTypeID, P.ProductName, P.Quantity
FROM Product P
WHERE P.ProductTypeID = 2

/*Question #8*/
SELECT OL.OrderID, P.ProductName, OL.Quantity 
FROM Sales.OrderLines OL
    INNER JOIN Product P ON P.ProductID = OL.ProductID
WHERE OL.OrderID = 2
