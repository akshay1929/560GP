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

SELECT *
FROM Users.Member

SELECT *
FROM Warehouse.Shipment

INSERT Sales.Orders(OrderDate, ShipmentAddress)
VALUES 
    (N'05-11-2020 11:00:00.0000000 -05:00', N'762-4876 Risus. Av.'), 
    (N'27-07-2020 12:00:00.0000000 -05:00', N'7182 Ornare. Av.'), 
    (N'05-10-2020 13:00:00.0000000 -05:00', N'P.O. Box 387, 2496 Odio St.'), 
    (N'26-05-2019 14:00:00.0000000 -05:00', N'792-140 Dapibus St.'), 
    (N'01-10-2019 15:00:00.0000000 -05:00', N'376-1818 Fermentum Rd.'), 
    (N'14-11-2019 16:00:00.0000000 -05:00', N'Ap #385-9042 Scelerisque St.'), 
    (N'04-10-2019 17:00:00.0000000 -05:00', N'Ap #188-4974 Donec Road'), 
    (N'04-01-2020 18:00:00.0000000 -05:00', N'486-6876 Diam. Avenue'), 
    (N'16-04-2020 19:00:00.0000000 -05:00', N'P.O. Box 490, 1718 Elit. Rd.'), 
    (N'15-11-2019 10:55:00.0000000 -05:00', N'537-6249 Adipiscing Rd.'), 
    (N'23-04-2020 15:50:00.0000000 -05:00', N'158-1921 Odio Rd.'), 
    (N'25-02-2021 18:40:00.0000000 -05:00', N'612 Sagittis Road'), 
    (N'19-03-2021 12:30:00.0000000 -05:00', N'Ap #448-6685 Est Av.'), 
    (N'02-03-2021 11:20:00.0000000 -05:00', N'Ap #276-1618 Orci. St.'), 
    (N'02-05-2019 17:10:00.0000000 -05:00', N'Ap #241-3034 Cursus Av.'); 
    /*
    ((SELECT M.MemberID FROM Users.Member M), N'05-11-2020 11:00:00.0000000 -05:00', N'762-4876 Risus. Av.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'27-07-2020 12:00:00.0000000 -05:00', N'7182 Ornare. Av.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'05-10-2020 13:00:00.0000000 -05:00', N'P.O. Box 387, 2496 Odio St.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'26-05-2019 14:00:00.0000000 -05:00', N'792-140 Dapibus St.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'01-10-2019 15:00:00.0000000 -05:00', N'376-1818 Fermentum Rd.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'14-11-2019 16:00:00.0000000 -05:00', N'Ap #385-9042 Scelerisque St.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'04-10-2019 17:00:00.0000000 -05:00', N'Ap #188-4974 Donec Road'), 
    ((SELECT M.MemberID FROM Users.Member M), N'04-01-2020 18:00:00.0000000 -05:00', N'486-6876 Diam. Avenue'), 
    ((SELECT M.MemberID FROM Users.Member M), N'16-04-2020 19:00:00.0000000 -05:00', N'P.O. Box 490, 1718 Elit. Rd.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'15-11-2019 10:55:00.0000000 -05:00', N'537-6249 Adipiscing Rd.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'23-04-2020 15:50:00.0000000 -05:00', N'158-1921 Odio Rd.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'25-02-2021 18:40:00.0000000 -05:00', N'612 Sagittis Road'), 
    ((SELECT M.MemberID FROM Users.Member M), N'19-03-2021 12:30:00.0000000 -05:00', N'Ap #448-6685 Est Av.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'02-03-2021 11:20:00.0000000 -05:00', N'Ap #276-1618 Orci. St.'), 
    ((SELECT M.MemberID FROM Users.Member M), N'02-05-2019 17:10:00.0000000 -05:00', N'Ap #241-3034 Cursus Av.');
    */

INSERT Sales.OrderLines(Quantity, UnitPrice)
VALUES    
    (2, 29.5), 
    (5, 38.17), 
    (6, 58.5), 
    (4, 42.23), 
    (8, 97.8), 
    (9, 74.5), 
    (1, 52.03), 
    (3, 80.54), 
    (4, 66.63), 
    (8, 60.7), 
    (6, 92.02), 
    (5, 86.42), 
    (7, 74.25), 
    (9, 17.61), 
    (4, 81.08); 

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