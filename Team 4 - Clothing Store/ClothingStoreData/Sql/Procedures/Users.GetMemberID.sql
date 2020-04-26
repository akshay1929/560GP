CREATE OR ALTER PROCEDURE Users.GetMemberID
   @GivenMemberid INT;
AS

SELECT M.MemberID, M.Status
FROM Users.Member M
WHERE M.MemberID = @GivenMemberid
GROUP BY M.MemberID, M.Status
ORDER BY M.MemberID ASC
GO