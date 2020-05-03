CREATE OR ALTER PROCEDURE Product.RetrieveProductTypeCount
AS

SELECT PT.[Name], COUNT(O.OrderID) AS OrdersPlaced, P.SKU
FROM Product.ProductType PT
    INNER JOIN Product P ON P.ProductTypeID = PT.ProductTypeID
		INNER JOIN Sales.OrderLines OL ON OL.ProductID = P.ProductID
		INNER JOIN Sales.Orders O ON O.OrderID = OL.OrderID
GROUP BY PT.[Name], P.SKU
ORDER BY COUNT(O.OrderID) DESC, P.SKU DESC
GO