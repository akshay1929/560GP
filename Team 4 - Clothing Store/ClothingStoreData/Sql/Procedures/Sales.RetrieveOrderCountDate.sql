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
GROUP BY O.OrderID

