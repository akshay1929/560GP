CREATE OR ALTER PROCEDURE Product.GetOrderIdName
   @GivenOrderID INT;
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