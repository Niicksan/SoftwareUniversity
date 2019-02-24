CREATE TABLE Cities (
	CityID INT NOT NULL,
	[Name] VARCHAR(50)
);

ALTER TABLE Cities
	ADD CONSTRAINT PK_Cities
PRIMARY KEY (CityID);

CREATE TABLE Customers (
	CustomerID INT NOT NULL,
	[Name] VARCHAR(50),
	Birthday DATE,
	CityID INT NOT NULL
);

ALTER TABLE Customers
	ADD CONSTRAINT PK_Customers
PRIMARY KEY (CustomerID);

ALTER TABLE Customers
	ADD CONSTRAINT FK_Cities
FOREIGN KEY (CityID) REFERENCES Cities(CityID);

CREATE TABLE Orders (
	OrderID INT NOT NULL,
	CustomerID INT NOT NULL
);

ALTER TABLE Orders
	ADD CONSTRAINT PK_Orders
PRIMARY KEY (OrderID);

ALTER TABLE Orders
	ADD CONSTRAINT FK_OrdersCustomers
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID);

CREATE TABLE Items (
	ItemID INT NOT NULL,
	[Name] VARCHAR(50),
	ItemTypeID INT NOT NULL
);

ALTER TABLE Items
	ADD CONSTRAINT PK_Items
PRIMARY KEY (ItemID);

CREATE TABLE OrderItems (
	OrderID INT NOT NULL,
	ItemID INT NOT NULL
);

ALTER TABLE OrderItems
	ADD CONSTRAINT PK_OrderItems
PRIMARY KEY (OrderID, ItemID);

ALTER TABLE OrderItems
	ADD CONSTRAINT FK_Orders
FOREIGN KEY (OrderID) REFERENCES Orders(OrderID);

ALTER TABLE OrderItems
	ADD CONSTRAINT FK_Items 
FOREIGN KEY (ItemID) REFERENCES Items(ItemID);

CREATE TABLE ItemTypes (
	ItemTypeID INT NOT NULL,
	[Name] VARCHAR(50)
);

ALTER TABLE ItemTypes
	ADD CONSTRAINT PK_ItemTypes
PRIMARY KEY (ItemTypeID);

ALTER TABLE Items
	ADD CONSTRAINT FK_ItemTypes 
FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID);