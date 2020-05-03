CREATE OR ALTER PROCEDURE Users.FetchMemberStatus
   @GivenMemberid INT
AS

SELECT M.MemberID, M.FirstName, M.LastName, M.Points, M.[Status]
FROM Users.Member M
WHERE M.MemberID = @GivenMemberid
GROUP BY M.MemberID, M.[Status], M.FirstName, M.LastName, M.Points
GO