CREATE OR ALTER PROCEDURE Users.RetrieveMemberPoints
AS

SELECT 
	M.FirstName, 
	M.LastName, 
	M.Points, 
	M.[Status]
FROM 
	Users.Member M
ORDER BY 
	M.Points DESC
GO
