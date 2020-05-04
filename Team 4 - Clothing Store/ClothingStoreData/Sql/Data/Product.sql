DECLARE @ProductStaging TABLE
(
	ProductID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	SKU NVARCHAR(32) NOT NULL UNIQUE,
	ProductName NVARCHAR(64) NOT NULL,
    ProductTypeID INT NOT NULL FOREIGN KEY
        REFERENCES Product.ProductType(ProductTypeID),
	Quantity INT NOT NULL,
    [Description] NVARCHAR(MAX) NOT NULL,
    Price NVARCHAR(32) NOT NULL,
	Rating NVARCHAR(32) NOT NULL 
);

/***************************** Modify values here *****************************/

INSERT @ProductStaging(SKU, ProductName, Quantity, [Description], Price, Rating, ProductTypeID)
VALUES
	(N'SP92UQDB', N'Elouise Crop Top', 600, N'Crop top. Button front. Ruffle detailing. Short elasticated sleeves. Cotton polyester blend', 27.23, 4.5, 1),
    (N'BX97VKGC', N'Laura Grace Top', 600, N'Plunging neckline. Relaxed fit. Ruched hem detailing. Tie at front design. Fixed straps', 20.59, 4.1, 2),
    (N'OZ26JNLG', N'Bennet Crop Top', 600, N'Basic tee. Cropped design. Ribbed material. Unlined. Slim fit. Short capped sleeves. Cotton polyester blend', 27.37, 3.9, 1),
    (N'PK43IZIP', N'Attica Jean', 700, N'Denim jeans. High waisted fit. Straight leg. Raw cut hem. Contrast stitching. Belt loops at waist. Classic 5 pocket design', 45.19, 3.5, 3),
    (N'RU00OFLB', N'Mom Jean Denim', 700, N'Denim jeans. High waisted fit. Step hem. Raw cut detailing. Slim leg. Zip & button fastening', 45.17, 4.9, 3),
    (N'EJ22IKFJ', N'Verona Midi Skirt', 650, N'Midi skirt. Off center slit. Darting seams through waist. Invisible zip at back. Unlined. 100% polyester', 33.53, 4.1, 12),
    (N'AK09OBOS', N'Addison Mae Mini Skirt', 650, N'Mini skirt. High waisted fit. Darting seams at waist. Invisible zip at back. Unlined. 100% polyester', 38.21, 4.3, 11),
    (N'VK39DQPJ', N'Beach House Shorts', 550, N'High rise shorts. Elasticated waistband. Relaxed fit. Linen look. Cotton Polyester blend', 45.06, 4.7, 4),
    (N'ZM88NVVW', N'Deputy Shorts', 550, N'Highwaisted shorts. Classic 5 pocket design. Belt loops at waist. Zip and button closure', 53.77, 4.6, 5),
    (N'ZT08FRQB', N'Sinclair Mini Dress', 1000, N'Mini dress. Straight neckline. Invisible zip fastening at back. Adjustable straps. Subtle ruffle detailing at hem. 65% Cotton 35% Polyester', 60.53, 3.8, 6),
    (N'XA68WGQP', N'Daisy Fae Mini Dress', 1000, N'Mini dress. Wrap front style. Tie side skirt. Ruffle hemline. Straight neckline. Slim adjustable straps. Invisible zip at back. 65% Cotton 35% Polyester', 58.17, 4.2, 6),
    (N'YW24MZVB', N'Cayley Tee Dress', 1000, N'Mini dress. T-shirt style. Crew neckline. Soft textured material. Relaxed fitting. 75% rayon 20% polyester 5% elastane', 64.63, 3.9, 7),
    (N'JZ46HBDI', N'Sienna Playsuit', 1000, N'Luxe playsuit. Tie at waist. Layered ruffle skirt detail. Low cut exposed back. Crossed adjustable straps. Invisible zip fastening at back. 100% Polyester', 62.74, 4.0, 8),
    (N'UL23ZOXC', N'Teddy Coat', 500, N'Oversized faux fur coat. Collared neckline. Front zip fastening. Twin front pockets. Elasticated cuffs and band. 100% Polyester', 67.55, 4.4, 9),
    (N'EV77KGZB', N'Polly Puffer Jacket', 500, N'Puffer jacket. Front zip fastening. Twin pockets at front. High neckline. Corduroy design. 100% cotton', 75.08, 4.6, 10); 

/******************************************************************************/

MERGE Product P
USING @ProductStaging S ON S.ProductId = P.ProductId
WHEN MATCHED AND S.ProductName <> P.ProductName THEN
   UPDATE
   SET ProductName = S.ProductName
WHEN NOT MATCHED THEN
   INSERT(ProductId, SKU, ProductName, Quantity, [Description], Price, Rating, ProductTypeID)
   VALUES(S.ProductId, S.SKU, S.ProductName, S.Quantity, S.[Description], S.Price, S.Rating, S.ProductTypeID);
