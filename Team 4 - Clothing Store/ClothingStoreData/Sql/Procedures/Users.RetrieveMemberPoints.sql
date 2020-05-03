CREATE OR ALTER PROCEDURE Users.RetrieveMemberPoints
AS

SELECT *
FROM 
	Users.Member M
ORDER BY 
	M.Points DESC
GO
