DECLARE @ShipmentStaging TABLE
(
   ShipmentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   ShipmentDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   ShipmentAddress NVARCHAR(128) NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

INSERT @ShipmentStaging(MemberID, EmployeeID, ShipmentID, OrderDate, ShipmentAddress)
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