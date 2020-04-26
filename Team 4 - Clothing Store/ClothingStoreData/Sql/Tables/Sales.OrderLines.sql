BEGIN 
	CREATE TABLE Sales.OrderLines
	(
	    OrderLineID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	    OrderID INT NOT NULL FOREIGN KEY
	        REFERENCES Sales.Orders(OrderID),
	    ProductID INT NOT NULL FOREIGN KEY
	        REFERENCES Product(ProductID),
	    Quantity INT NOT NULL,
	    UnitPrice FLOAT NOT NULL
	);
END