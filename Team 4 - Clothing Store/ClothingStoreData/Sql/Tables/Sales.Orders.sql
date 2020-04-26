BEGIN
	CREATE TABLE Sales.Orders
	(
    OrderID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL FOREIGN KEY
        REFERENCES Users.Member(MemberID),
    EmployeeID INT NOT NULL FOREIGN KEY
        REFERENCES Sales.Employees(EmployeeID),
    ShipmentID INT NOT NULL FOREIGN KEY
        REFERENCES Warehouse.Shipment(ShipmentID),
    OrderDate DATETIMEOFFSET NOT NULL DEFAULT SYSDATETIMEOFFSET(),
    ShipmentAddress NVARCHAR(128) NOT NULL DEFAULT(SYSDATETIMEOFFSET())

    UNIQUE 
    (
        MemberID,
        EmployeeID
    )
);
END