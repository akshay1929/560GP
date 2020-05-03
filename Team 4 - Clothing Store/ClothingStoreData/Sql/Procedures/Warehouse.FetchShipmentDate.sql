CREATE OR ALTER PROCEDURE Warehouse.FetchShipmentDate
   @GivenOrderID INT
AS

SELECT *
FROM Warehouse.Shipment S
    INNER JOIN Sales.Orders O ON O.ShipmentID = S.ShipmentID
WHERE O.OrderID = @GivenOrderID
GO