CREATE OR ALTER PROCEDURE Users.UpdateMember
   @GivenMemberID INT,
   @GivenEmail NVARCHAR(128),
   @GivenFirstName NVARCHAR(32),
   @GivenLastName NVARCHAR(32),
   @GivenPhone NVARCHAR(32),
   @GivenBillingAddress NVARCHAR(128),
   @GivenPoints INT,
   @GivenJoinedOn DATETIMEOFFSET,
   @GivenBirthDate DATETIMEOFFSET,
   @GivenStatus NVARCHAR(32)
AS

SELECT *
FROM Users.Member;

UPDATE Users.Member
SET   
	MemberID = @GivenMemberID,
	Email = @GivenEmail,
	FirstName = @GivenFirstName,
	LastName = @GivenLastName,
	Phone = @GivenPhone,
	BillingAddress = @GivenBillingAddress,
	Points = @GivenPoints,
	JoinedOn = @GivenJoinedOn,
	BirthDate = @GivenBirthDate,
	[Status] = @GivenStatus
WHERE MemberID = @GivenMemberID
GO
