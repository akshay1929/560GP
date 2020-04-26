CREATE OR ALTER PROCEDURE Warehouse.GetShipmentAddress
   @GivenAddress NVARCHAR(128);
AS

SELECT S.ShipmentID, S.ShipmentAddress, O.OrderID
FROM Sales.Orders O
    INNER JOIN Warehouse.Shipment S ON S.ShipmentAddress = O.ShipmentAddress
WHERE S.ShipmentAddress = @GivenAddress
GROUP BY S.ShipmentID, S.ShipmentAddress, O.OrderID
ORDER BY S.ShipmentID ASC