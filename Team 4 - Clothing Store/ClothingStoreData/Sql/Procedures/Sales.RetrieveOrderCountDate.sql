CREATE OR ALTER PROCEDURE Sales.RetrieveOrderCountDate
 @StartDate DATETIMEOFFSET,
 @EndDate DATETIMEOFFSET

 AS

SELECT 
    COUNT(O.OrderID) AS TotalOrders
FROM 
	Sales.Orders O
WHERE
	O.OrderDate BETWEEN @StartDate AND @EndDate

