CREATE OR ALTER PROCEDURE Product.RetrieveHighestRatings
AS

SELECT 
	P.ProductId, P.SKU, P.ProductName, P.Quantity, P.[Description], P.Price, P.Rating
FROM 
	Product P
ORDER BY 
	P.Rating DESC
GO
