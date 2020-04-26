DECLARE @MemberStaging TABLE
(
   MemberID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   Email NVARCHAR(128) NOT NULL,
   FirstName NVARCHAR(32) NOT NULL,
   LastName NVARCHAR(32) NOT NULL,
   Phone NVARCHAR(32) NOT NULL,
   BillingAddress NVARCHAR(128) NOT NULL,
   Points INT NOT NULL,
   JoinedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   BirthDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   [Status] NVARCHAR(32) NOT NULL,
   
   UNIQUE    
   (      
       Email,
       Phone   
   )
);



INSERT @MemberStaging(Email, FirstName, LastName, Phone, BillingAddress, Points, JoinedOn, BirthDate, [Status])
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
