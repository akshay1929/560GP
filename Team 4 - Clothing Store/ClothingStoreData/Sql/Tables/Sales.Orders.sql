IF OBJECT_ID(N'Sales.Orders') IS NULL
BEGIN
	CREATE TABLE Sales.Orders
	(
    OrderID INT NOT NULL IDENTITY(1,1),
    MemberID INT NOT NULL FOREIGN KEY
        REFERENCES Users.Member(MemberID),
    EmployeeID INT NOT NULL FOREIGN KEY
        REFERENCES Sales.Employees(EmployeeID),
    ShipmentID INT NOT NULL FOREIGN KEY
        REFERENCES Warehouse.Shipment(ShipmentID),
    OrderDate DATETIMEOFFSET NOT NULL DEFAULT SYSDATETIMEOFFSET(),
    ShipmentAddress NVARCHAR(128) NOT NULL DEFAULT(SYSDATETIMEOFFSET())

    CONSTRAINT [PK_Sales_Orders_OrderID] PRIMARY KEY CLUSTERED
      (
         OrderID ASC
      )
);
END;