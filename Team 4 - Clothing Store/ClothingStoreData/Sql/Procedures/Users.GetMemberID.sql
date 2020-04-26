CREATE OR ALTER PROCEDURE Member.GetMemberId
   @GivenEmail NVARCHAR(128)
AS

SELECT M.MemberID, M.FirstName, M.LastName
FROM Users.Member M
WHERE M.Email = @GivenEmail
