IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Product'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Product] AUTHORIZATION [dbo]');
END;