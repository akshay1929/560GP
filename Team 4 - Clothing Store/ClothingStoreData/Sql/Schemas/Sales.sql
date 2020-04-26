IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Sales'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Sales] AUTHORIZATION [dbo]');
END;