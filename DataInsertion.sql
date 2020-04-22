INSERT Sales.Employees(Email, [Name], EmployeeRole, Salary)
VALUES
    (N'felis.adipiscing@semperet.edu', N'Jonah', N'Manager', 4588.07), 
    (N'Cras@ante.com', N'Axel', N'Sales ', 5913.55), 
    (N'Proin.eget@egetlaoreet.co.uk', N'Xenos', N'Marketing', 7578.33), 
    (N'turpis.In.condimentum@Fuscemollis.co.uk', N'Tanek', N'Warehouse', 9444.51), 
    (N'ligula.eu@accumsansed.org', N'Wesley', N'Shipping', 7459.37), 
    (N'Vivamus@Aliquamnecenim.com', N'Mannix', N'Purchase', 8294.34), 
    (N'a.mi@infelisNulla.co.uk', N'Ryder', N'IT', 1444.54), 
    (N'Aliquam.erat@nuncullamcorpereu.net', N'Tiger', N'Web Development', 3492.11), 
    (N'orci.consectetuer.euismod@vitae.org', N'Victor', N'Customer Care', 1933.25), 
    (N'mauris.ipsum.porta@urnaUttincidunt.co.uk', N'Victor', N'Packaging ', 1210.9), 
    (N'Duis.gravida@auctor.com', N'Linus', N'Delivery', 1305.22), 
    (N'Aenean.gravida@leoMorbineque.org', N'Jacob', N'HR', 1198.91), 
    (N'orci.Phasellus.dapibus@Fuscediam.ca', N'Arthur', N'Quality Control', 4830.47), 
    (N'elit.Nulla.facilisi@pedeCumsociis.ca', N'Duncan', N'Security', 5416.07), 
    (N'a.arcu@eratnequenon.net', N'Noble', N'Graphical', 7860.37); 

SELECT *
FROM Sales.Employees




INSERT Users.Member(Email, FirstName, LastName, Phone, BillingAddress, Points, JoinedOn, BirthDate, [Status])
VALUES 
    (N'art@venere.org', N'Art', N'Venere', N'856-636-8749', N'8 W Cerritos Ave #54', N'30', N'2017-11-22', N'1999-10-06', N'Active'),
    (N'leota@hotmail.com', N'Leota', N'Dilliard', N'408-752-3500', N'7 W Jackson Blvd', N'90', N'2018-09-09', N'1992-08-19', N'Active'),
    (N'kiley.caldarera@aol.com', N'Kiley', N'Caldarera', N'310-498-5651', N'25 E 75th St #69', N'80', N'2018-06-12', N'1990-04-21', N'Inactive'),
    (N'vinouye@aol.com', N'Veronika', N'Inouye', N'408-540-1785', N'6 Greenleaf Ave', N'50', N'2017-05-02', N'2000-01-01', N'Active'),
    (N'calbares@gmail.com', N'Cammy', N'Albares', N'956-537-6195', N'56 E Morehead St', N'80', N'2020-02-26', N'1987-11-29', N'Inactive'),
    (N'wkusko@yahoo.com', N'Willow', N'Kusko', N'212-582-4976', N'90991 Thorburn Ave', N'10', N'2017-01-04', N'1985-12-25', N'Active'),
    (N'amber_monarrez@monarrez.org', N'Amber', N'Monarrez', N'215-934-8655', N'14288 Foster Ave #4121', N'30', N'2017-12-26', N'1995-10-30', N'Active'),
    (N'deeanna_juhas@gmail.com', N'Deeanna', N'Juhas', N'215-211-9589', N'14302 Pennsylvania Ave', N'50', N'2017-12-01', N'1990-07-24', N'Active'),
    (N'cecily@hollack.org', N'Cecily', N'Hollack', N'512-486-3817', N'59 N Groesbeck Hwy', N'90', N'2018-04-09', N'2000-05-16', N'Inactive'),
    (N'ilene.eroman@hotmail.com', N'Ilene', N'Eroman', N'410-914-9018', N'2853 S Central Expy', N'100', N'2017-11-19', N'1988-03-04', N'Inactive'),
    (N'moon@yahoo.com', N'Moon', N'Parlato', N'585-866-8313', N'74989 Brandon St', N'70', N'2019-02-28', N'1985-11-13', N'Active'),
    (N'devorah@hotmail.com', N'Devorah', N'Chickering', N'505-975-8559', N'31 Douglas Blvd #950', N'60', N'2018-10-09', N'1997-01-22', N'Active'),
    (N'shonda_greenbush@cox.net', N'Shonda', N'Greenbush', N'973-482-2430', N'82 Us Highway 46', N'70', N'2020-01-15', N'1998-09-09', N'Active'),
    (N'jacqueline.rowling@yahoo.com', N'Jacqueline', N'Rowling', N'814-865-8113', N'1 N San Saba', N'90', N'2018-03-27', N'1991-02-28', N'Active'),
    (N'jgabisi@hotmail.com', N'Janey', N'Gabisi', N'608-967-7194', N'40 Cambridge Ave', N'40', N'2019-06-14', N'1982-08-31', N'Inactive'); 

SELECT *
FROM Users.Member


INSERT Warehouse.Shipment(ShipmentDate, ShipmentAddress)
VALUES 
    (N'2018-10-09 11:00:00.0000000 -05:00', N'8 W Cerritos Ave #54'),
    (N'2018-08-19 11:00:00.0000000 -05:00', N'7 W Jackson Blvd'),
    (N'2019-11-25 11:00:00.0000000 -05:00', N'87895 Concord Rd'),
    (N'2018-04-03 11:00:00.0000000 -05:00', N'6 Greenleaf Ave'),
    (N'2020-04-16 11:00:00.0000000 -05:00', N'56 E Morehead St'),
    (N'2017-09-09 11:00:00.0000000 -05:00', N'2 Sw Nyberg Rd'),
    (N'2018-01-02 11:00:00.0000000 -05:00', N'105 Richmond Valley Rd'),
    (N'2017-12-15 11:00:00.0000000 -05:00', N'14302 Pennsylvania Ave'),
    (N'2018-05-26 11:00:00.0000000 -05:00', N'59 N Groesbeck Hwy'),
    (N'2018-02-19 11:00:00.0000000 -05:00', N'278 Bayview Ave'),
    (N'2019-06-23 11:00:00.0000000 -05:00', N'74989 Brandon St'),
    (N'2018-10-31 11:00:00.0000000 -05:00', N'31 Douglas Blvd #950'),
    (N'2020-03-30 11:00:00.0000000 -05:00', N'82 Us Highway 46'),
    (N'2018-10-27 11:00:00.0000000 -05:00', N'1 N San Saba'),
    (N'2019-11-09 11:00:00.0000000 -05:00', N'82 Winsor St #54');



SELECT *
FROM Warehouse.Shipment

INSERT Sales.Orders(MemberID, EmployeeID, ShipmentID, OrderDate, ShipmentAddress)
VALUES 
    (1, 1, 1, N'2020-08-14', N'762-4876 Risus. Av.'), 
    (2, 2, 2, N'2020-03-13', N'7182 Ornare. Av.'), 
    (3, 3, 3, N'2019-11-05', N'P.O. Box 387, 2496 Odio St.'), 
    (4, 4, 4, N'2020-07-13', N'792-140 Dapibus St.'), 
    (5, 5, 5, N'2019-10-28', N'376-1818 Fermentum Rd.'), 
    (6, 6, 6, N'2020-08-07', N'Ap #385-9042 Scelerisque St.'), 
    (7, 7, 7, N'2020-07-02', N'Ap #188-4974 Donec Road'), 
    (8, 8, 8, N'2019-08-28', N'486-6876 Diam. Avenue'), 
    (9, 9, 9, N'2020-11-07', N'P.O. Box 490, 1718 Elit. Rd.'), 
    (10, 10, 10, N'2021-02-27', N'537-6249 Adipiscing Rd.'), 
    (11, 11, 11, N'2020-07-03', N'158-1921 Odio Rd.'), 
    (12, 12, 12, N'2019-06-20', N'612 Sagittis Road'), 
    (13, 13, 13, N'2020-07-13', N'Ap #448-6685 Est Av.'), 
    (14, 14, 14, N'2019-09-15', N'Ap #276-1618 Orci. St.'), 
    (15, 15, 15, N'2019-12-18', N'Ap #241-3034 Cursus Av.'); 



SELECT *
FROM Sales.Orders



INSERT Product.ProductType([Name])
VALUES 
	(N'Crop Tops'),
	(N'Shirts & Blouses'),
	(N'Denim Jeans'),
	(N'Loungewear Shorts'),
	(N'Denim Shorts'),
	(N'Mini Dress'),
	(N'Dresses'),
	(N'Playsuits & Rompers'),
	(N'Coats'),
	(N'Jackets'),
	(N'Mini Skirts'),
	(N'Midi Skirts');


SELECT *
FROM Product.ProductType

INSERT Product(SKU, ProductName, Quantity, [Description], Price, Rating, ProductTypeID)
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


SELECT *
FROM Product

INSERT Sales.OrderLines(OrderID, ProductID, Quantity, UnitPrice)
VALUES    
    (1, 1, 2, 29.5), 
    (2, 2, 5, 38.17), 
    (3, 3, 6, 58.5), 
    (4, 4, 4, 42.23), 
    (5, 5, 8, 97.8), 
    (6, 6, 9, 74.5), 
    (7, 7, 1, 52.03), 
    (8, 8, 3, 80.54), 
    (9, 9, 4, 66.63), 
    (10, 10, 8, 60.7), 
    (11, 11, 6, 92.02), 
    (12, 12, 5, 86.42), 
    (13, 8, 7, 74.25), 
    (14, 4, 9, 17.61), 
    (15, 9, 4, 81.08); 

SELECT *
FROM Sales.OrderLines
