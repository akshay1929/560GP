DECLARE @ProductTypeStaging TABLE
(
	ProductTypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(32) NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @ProductTypeStaging(ProductTypeID, [Name])
VALUES
	(1, N'Crop Tops'),
	(2, N'Shirts & Blouses'),
	(3, N'Denim Jeans'),
	(4, N'Loungewear Shorts'),
	(5, N'Denim Shorts'),
	(6, N'Mini Dress'),
	(7, N'Dresses'),
	(8, N'Playsuits & Rompers'),
	(9, N'Coats'),
	(10, N'Jackets'),
	(11, N'Mini Skirts'),
	(12, N'Midi Skirts');

/******************************************************************************/

MERGE Product.ProductType PT
USING @ProductTypeStaging S ON S.ProductTypeId = PT.ProductTypeId
WHEN MATCHED AND S.[Name] <> PT.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(ProductTypeId, [Name])
   VALUES(S.ProductTypeId, S.[Name]);
