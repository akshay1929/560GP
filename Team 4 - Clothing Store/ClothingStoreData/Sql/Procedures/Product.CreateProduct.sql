CREATE OR ALTER PROCEDURE Product.CreateProduct
   @SKU NVARCHAR(32),
   @ProductName NVARCHAR(64),
   @ProductTypeId INT,
   @Quantity INT,
   @Description NVARCHAR(MAX),
   @Price Float,
   @Rating Float,
   @ProductId INT OUTPUT
AS

INSERT Product(SKU, ProductName, ProductTypeId, Quantity, [Description], Price, Rating)
VALUES(@SKU, @ProductName, @ProductTypeId, @Quantity, @Description, @Price, @Rating);

SET @ProductId = SCOPE_IDENTITY();
GO
