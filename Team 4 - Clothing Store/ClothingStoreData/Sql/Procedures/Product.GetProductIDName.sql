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