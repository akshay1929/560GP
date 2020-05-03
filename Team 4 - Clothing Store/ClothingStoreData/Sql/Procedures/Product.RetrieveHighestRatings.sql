CREATE OR ALTER PROCEDURE Product.RetrieveHighestRatings
AS

SELECT *
FROM 
	Product P
ORDER BY 
	P.Rating DESC, P.ProductName ASC
GO
