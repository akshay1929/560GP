DECLARE @OrderLinesStaging TABLE
(
		OrderLineID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	    OrderID INT NOT NULL FOREIGN KEY
	        REFERENCES Sales.Orders(OrderID),
	    ProductID INT NOT NULL FOREIGN KEY
	        REFERENCES Product(ProductID),
	    Quantity INT NOT NULL,
	    UnitPrice FLOAT NOT NULL
);

INSERT @OrderLinesStaging(OrderID, ProductID, Quantity, UnitPrice)
VALUES
   (1, 1, 2, 29.5), 
    (2, 2, 5, 38.17), 
    (3, 3, 6, 58.5), 
    (4, 4, 4, 42.23), 
    (5, 5, 8, 97.8), 
    (6, 6, 9, 74.5), 
    (7, 7, 1, 52.03), 
    (8, 8, 3, 80.54), 
    (9, 9, 4, 66.63), 
    (10, 10, 8, 60.7), 
    (11, 11, 6, 92.02), 
    (12, 12, 5, 86.42), 
    (13, 8, 7, 74.25), 
    (14, 4, 9, 17.61), 
    (15, 9, 4, 81.08); 

