CREATE OR ALTER PROCEDURE Product.RetrieveProducts
AS

SELECT *
FROM Product P
	LEFT JOIN Product.ProductType PT ON PT.ProductTypeID = P.ProductTypeID;
GO
