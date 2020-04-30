CREATE OR ALTER PROCEDURE Product.RetrieveProductTypeCount
AS

SELECT PT.[Name], COUNT(O.OrderID) AS OrderCount, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
	INNER JOIN Sales.Orders O ON O.ProductID = P.ProductID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(P.ProductID) DESC, P.SKU DESC
GO