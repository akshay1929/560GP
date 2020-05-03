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
