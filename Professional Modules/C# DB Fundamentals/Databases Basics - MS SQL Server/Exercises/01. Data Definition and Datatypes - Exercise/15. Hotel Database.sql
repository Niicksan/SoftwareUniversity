CREATE DATABASE Hotel;

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Title NVARCHAR(100) NOT NULL,
	Notes TEXT
)

INSERT INTO Employees (FirstName, LastName, Title, Notes) VALUES 
('Nik', 'Koev', 'Main administrator', 'Best Admin Ever'),
('Emy', 'Nedialkova', 'Main administrator', 'Best Admin Ever'),
('Georgi', 'Bunov', 'retseptsionist', 'Employee of the year')

CREATE TABLE Customers (
	AccountNumber INT PRIMARY KEY IDENTITY  NOT NULL,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	PhoneNumber NVARCHAR(10) NOT NULL,
	EmergencyName NVARCHAR(100) NOT NULL,
	EmergencyNumber NVARCHAR(3) NOT NULL,
	Notes TEXT
)

INSERT INTO Customers (FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes) VALUES 
('Nick', 'Washington', '0897657345', 'Fire', '160', 'No'),
('Emily', 'Writer', '0895657423', 'Police', '166', 'Yes'),
('Piter', 'Jackson', '0887342215', 'Ambulance', '150', 'No')

CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR(30) NOT NULL,
	Notes TEXT
)

INSERT INTO RoomStatus (RoomStatus, Notes) VALUES
('Available', 'free'),
('Unavailable', 'busy'),
('Under maintenance', 'unavailable')

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(30) NOT NULL,
	Notes TEXT
)

INSERT INTO RoomTypes (RoomType, Notes) VALUES
('Single', 'one room'),
('Double', 'two rooms'),
('Double withe a terrace', 'there is a balcon')

CREATE TABLE BedTypes   (
	BedType NVARCHAR(30) NOT NULL,
	Notes TEXT
)

INSERT INTO BedTypes (BedType, Notes) VALUES
('Single', 'one bed'),
('Double', 'two beds'),
('Large bed', 'large bed')

CREATE TABLE Rooms (
	RoomNumber INT PRIMARY KEY IDENTITY  NOT NULL,
	RoomType NVARCHAR(50) NOT NULL,
	BedTypes NVARCHAR(50) NOT NULL,
	Rate INT,
	RoomStatus NVARCHAR(50) NOT NULL,
	Notes TEXT
)

INSERT INTO Rooms (RoomType, BedTypes, Rate, RoomStatus, Notes) VALUES
('Single', 'Double', 6, 'Available', 'Such a cool room'),
('Double', 'Single', 8, 'Available', 'Much better'),
('Double withe a terrace', 'Large bed', 10, 'Available', 'Wonderful view')


CREATE TABLE Payments (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees (Id) NOT NULL,
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers (AccountNumber) NOT NULL,
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays INT,
	AmountCharged MONEY,
	TaxRate INT,
	TaxAmount MONEY,
	PaymentTotal MONEY,
	Notes TEXT
) 

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes) VALUES
(1, '2019-01-26', 2, '2019-01-16', '2019-01-26', 11 , 120, 2, 240, 240, 'Yep, cool'),
(3, '2019-01-18', 3, '2019-01-15', '2019-01-18', 4 , 150, 1, 150, 150, 'Yep, well'),
(2, '2019-01-14', 1, '2019-01-01', '2019-01-14', 13 , 100, 3, 300, 300, 'Yep, its not bad')

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees (Id) NOT NULL,
	DateOccupied DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers (AccountNumber) NOT NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Rooms (RoomNumber) NOT NULL,
	RateApplied  INT,
	PhoneCharge MONEY,
	Notes TEXT
) 

INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes) VALUES
(1, '2019-01-16', 2, 3, 2, 23.50, 'Yep, cool'),
(3, '2019-01-15', 1, 2, 1, 38.60, 'Yep, well'),
(2, '2019-01-26', 3, 1, 3, 72.90, 'Yep, its not bad')