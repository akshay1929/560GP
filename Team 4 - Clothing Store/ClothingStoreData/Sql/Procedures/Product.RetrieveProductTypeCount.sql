CREATE OR ALTER PROCEDURE Product.RetrieveProductTypeCount
@Count INT
AS

SELECT PT.[Name], COUNT(O.OrderID) AS Count, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(P.ProductID) DESC, P.SKU DESC
GO