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
