CREATE OR ALTER PROCEDURE Product.GetProductTypeCount
  
AS

SELECT PT.[Name], COUNT(P.ProductID) AS OrderCount, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(P.ProductID) DESC, P.SKU DESC
GO