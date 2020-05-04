IF OBJECT_ID(N'Product') IS NULL
BEGIN
	CREATE TABLE Product
	(
		ProductID INT NOT NULL IDENTITY(1,1),
		SKU NVARCHAR(32) NOT NULL,
		ProductName NVARCHAR(64) NOT NULL,
		ProductTypeID INT NOT NULL,
		Quantity INT NOT NULL,
		[Description] NVARCHAR(MAX) NOT NULL,
		Price NVARCHAR(32) NOT NULL,
		Rating NVARCHAR(32) NOT NULL  

		CONSTRAINT [PK_Product_ProductID] PRIMARY KEY CLUSTERED
		(
         ProductID ASC
		),

		CONSTRAINT FK_Product_Product_ProductType FOREIGN KEY(ProductTypeId)
		REFERENCES Product.ProductType(ProductTypeId),
	);
END

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Product')
         AND kc.[name] = N'UK_Product_SKU'
   )
BEGIN
   ALTER TABLE Product
   ADD CONSTRAINT [UK_Product_SKU] UNIQUE NONCLUSTERED
   (
      SKU
   )
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Product')
         AND fk.referenced_object_id = OBJECT_ID(N'Product.ProductTypeID')
         AND fk.[name] = N'FK_Product_Product_ProductType'
   )
BEGIN
   ALTER TABLE Product
   ADD CONSTRAINT [FK_Product_Product_ProductType] FOREIGN KEY
   (
      ProductTypeID
   )
   REFERENCES Product.ProductType
   (
      ProductTypeID
   )
END;
