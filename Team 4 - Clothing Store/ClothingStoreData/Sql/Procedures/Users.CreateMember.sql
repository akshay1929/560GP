CREATE OR ALTER PROCEDURE Users.CreateMember
   @Email NVARCHAR(128),
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Phone NVARCHAR(32),
   @BillingAddress NVARCHAR(128),
   @Points INT,
   @JoinedOn DATETIMEOFFSET,
   @BirthDate DATETIMEOFFSET,
   @Status NVARCHAR(32),
   @MemberId INT OUTPUT
AS

INSERT Member(Email, FirstName, LastName, Phone, BillingAddress, Points, JoinedOn, BirthDate, [Status])
VALUES(@Email, @FirstName, @LastName, @Phone, @BillingAddress, @Points, @JoinedOn, @BirthDate, @Status);

SET @MemberId = SCOPE_IDENTITY();
GO
