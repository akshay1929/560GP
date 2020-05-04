CREATE OR ALTER PROCEDURE Sales.UpdateOrder
   @GivenOrderID INT,
   @GivenMemberID INT,
   @GivenEmployeeID INT,
   @GivenShipmentID INT,
   @GivenOrderDate DATETIMEOFFSET,
   @GivenShipmentAddress NVARCHAR(128)
AS

SELECT *
FROM Sales.Orders;

UPDATE Sales.Orders
SET   
	MemberID = @GivenMemberID,
	EmployeeID = @GivenEmployeeID,
	ShipmentID = @GivenShipmentID,
	OrderDate = @GivenOrderDate,
	ShipmentAddress = @GivenShipmentAddress
WHERE OrderID = @GivenOrderID
GO
