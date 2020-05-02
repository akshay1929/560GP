CREATE OR ALTER PROCEDURE Product.CreateProduct
   @SKU NVARCHAR(32),
   @ProductName NVARCHAR(64),
   @ProductTypeId INT,
   @Quantity INT,
   @Description NVARCHAR(MAX),
   @Price NVARCHAR(32),
   @Rating NVARCHAR(32),
   @ProductId INT OUTPUT
AS

INSERT Product(SKU, ProductName, ProductTypeId, Quantity, [Description], Price, Rating)
VALUES(@SKU, @ProductName, @ProductTypeId, @Quantity, @Description, @Price, @Rating);

SET @ProductId = SCOPE_IDENTITY();
GO
