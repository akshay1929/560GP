IF OBJECT_ID(N'Product.ProductType') IS NULL
BEGIN
	CREATE TABLE Product.ProductType
	(
		ProductTypeID INT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(32) NOT NULL

		CONSTRAINT [PK_Product_ProductType_ProductTypeID] PRIMARY KEY CLUSTERED
      (
         ProductTypeID ASC
      )
	);
END
