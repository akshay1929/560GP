IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Users'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Users] AUTHORIZATION [dbo]');
END;