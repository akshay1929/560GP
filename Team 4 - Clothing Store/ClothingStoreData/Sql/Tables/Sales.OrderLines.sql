IF OBJECT_ID(N'Sales.OrderLines') IS NULL
BEGIN 
	CREATE TABLE Sales.OrderLines
	(
	    OrderLineID INT NOT NULL IDENTITY(1,1),
	    OrderID INT NOT NULL FOREIGN KEY
	        REFERENCES Sales.Orders(OrderID),
	    ProductID INT NOT NULL FOREIGN KEY
	        REFERENCES Product(ProductID),
	    Quantity INT NOT NULL,
	    UnitPrice FLOAT NOT NULL

		CONSTRAINT [PK_Sales_OrderLines_OrderLineID] PRIMARY KEY CLUSTERED
      (
         OrderLineID ASC
      )
	);
END