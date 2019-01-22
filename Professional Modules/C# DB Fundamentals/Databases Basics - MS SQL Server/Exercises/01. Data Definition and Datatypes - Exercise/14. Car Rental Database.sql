CREATE DATABASE CarRental;

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	CategoryName NVARCHAR(100) NOT NULL,
	DailyRate MONEY NOT NULL,
	WeeklyRate MONEY NOT NULL,
	MonthlyRate MONEY NOT NULL,
	WeekendRate MONEY NOT NULL
)

INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES 
('Car', 20.00, 120.00, 550.00, 50.00), 
('Bus', 30.00, 150.00, 650.00, 60.00),
('Van', 25.00, 130.00, 600.00, 50.00)

CREATE TABLE Cars (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	PlateNumber NVARCHAR(10) NOT NULL,
	Manufacturer NVARCHAR(100) NOT NULL,
	Model NVARCHAR(100) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories (Id) NOT NULL,
	Doors INT,
	Picture IMAGE,
	Condition NVARCHAR(50),
	Available NVARCHAR(3) NOT NULL CHECK (Available IN ('yes','no')),
)

INSERT INTO Cars(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES 
('EB2307EA', 'Ford', 'Focus', 2008, 1, 5, 'pictures/ford_focus', 'very well', 'yes'), 
('EB3027AB', 'MErcedes', 'Sprint', 2003, 2, 3, 'pictures/mercedes_sprint', 'excellet', 'yes'),
('EB5630AA', 'Opel', 'Zafira', 2006, 3, 5, 'pictures/opel_zafira', 'well', 'no')

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
('Petur', 'Spasov', 'retseptsionist', 'Cool employee')

CREATE TABLE Customers (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	DriverLicenceNumber BIGINT NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	City NVARCHAR(100) NOT NULL,
	ZIPCode INT,
	Notes TEXT
)

INSERT INTO Customers (DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes) VALUES 
(2516160868, 'Ivan Petrov', 'bul. Ivan Asen 5', 'Varna', 9000, 'Travelling'),
(4553366834, 'Todor Laev', 'ul. Ivan Vazov 35', 'Sofia', 1000, 'Work'),
(1541266628, 'Asen Asenov', 'ul 3-ti Mart 87', 'Plovdiv', 4000, 'School')

CREATE TABLE RentalOrders  (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees (Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers (Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars (Id) NOT NULL,
	TankLevel NVARCHAR(50),
	KilometrageStart BIGINT,
	KilometrageEnd BIGINT,
	TotalKilometrage BIGINT,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	TotalDays INT,
	RateApplied NVARCHAR(10),
	TaxRate MONEY NOT NULL,
	OrderStatus NVARCHAR(50),
	Notes TEXT
)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1, 2, 3, 'full', 112345, 113355, 1010, '2019-01-15', '2019-01-21', 7, 'yes', 120.00, 'finished', 'Cool'),
(2, 3, 2, 'emty', 78543, 79244, 701, '2019-01-22', '2019-01-30', 9, 'no', 270.00, 'in process', 'Yeeh'),
(3, 1, 1, 'middle', 98235, 99333, 1098,'2019-01-01', '2019-01-14', 9, 'yes', 360.00, 'in process', 'Fun')