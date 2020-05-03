CREATE OR ALTER PROCEDURE Users.GetMemberId
   @GivenEmail NVARCHAR(128)
AS

SELECT *
FROM Users.Member M
WHERE M.Email = @GivenEmail
