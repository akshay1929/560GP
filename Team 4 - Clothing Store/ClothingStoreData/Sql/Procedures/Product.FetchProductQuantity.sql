CREATE OR ALTER PROCEDURE Product.FetchProductQuantity
   @GivenProductID INT
AS

SELECT 
	P.ProductName, P.Quantity
FROM 
	Product P
WHERE 
	P.ProductID = @GivenProductID
GO
