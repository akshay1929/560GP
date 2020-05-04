CREATE OR ALTER PROCEDURE Warehouse.CreateShipment
   @ShipmentDate DATETIMEOFFSET,
   @ShipmentAddress NVARCHAR(128),
   @ShipmentID INT OUTPUT
AS

INSERT Warehouse.Shipment(ShipmentDate, ShipmentAddress)
VALUES(@ShipmentDate, @ShipmentAddress);

SET @ShipmentID = SCOPE_IDENTITY();
GO
