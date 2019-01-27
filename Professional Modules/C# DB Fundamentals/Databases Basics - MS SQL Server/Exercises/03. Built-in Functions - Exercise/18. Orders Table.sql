SELECT 
	ProductName, 
	OrderDate,
	DATEADD(DAY, 3, OrderDate) AS [Pay Due],
	DATEADD(MONTH, 1, OrderDate) As [Delivery Due]
  FROM Orders;