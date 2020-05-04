CREATE OR ALTER PROCEDURE Product.UpdateProduct
   @GivenProductID INT,
   @GivenSKU NVARCHAR(32),
   @GivenProductName NVARCHAR(64),
   @GivenProductTypeID INT,
   @GivenQuantity INT,
   @GivenDescription NVARCHAR(MAX),
   @GivenPrice Float,
   @GivenRating NVARCHAR(32)
AS

SELECT *
FROM Product;

UPDATE Product
SET   
	SKU = @GivenSKU,
	ProductName = @GivenProductName,
	ProductTypeID = @GivenProductTypeID,
	Quantity = @GivenQuantity,
	[Description] = @GivenDescription,
	Price = @GivenPrice,
	Rating = @GivenRating

WHERE ProductID = @GivenProductID
GO
