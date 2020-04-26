IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Warehouse'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Warehouse] AUTHORIZATION [dbo]');
END;