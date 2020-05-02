DECLARE @OrdersStaging TABLE
(
   OrderID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL FOREIGN KEY
        REFERENCES Users.Member(MemberID),
    EmployeeID INT NOT NULL FOREIGN KEY
        REFERENCES Sales.Employees(EmployeeID),
    ShipmentID INT NOT NULL FOREIGN KEY
        REFERENCES Warehouse.Shipment(ShipmentID),
    OrderDate DATETIMEOFFSET NOT NULL DEFAULT SYSDATETIMEOFFSET(),
    ShipmentAddress NVARCHAR(128) NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);



INSERT @OrdersStaging(MemberID, EmployeeID, ShipmentID, OrderDate, ShipmentAddress)
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
