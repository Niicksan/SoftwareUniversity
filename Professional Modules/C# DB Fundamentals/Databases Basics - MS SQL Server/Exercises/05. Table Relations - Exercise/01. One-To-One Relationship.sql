CREATE TABLE Persons (
	PersonID INT NOT NULL,
	FirstName VARCHAR(50), 
	Salary MONEY,
	PassportID INT
);

CREATE TABLE Passports(
	PassportID INT NOT NULL,
	PassportNumber VARCHAR(50)
);

INSERT INTO Persons (PersonID, FirstName, Salary, PassportID) VALUES
(1, 'Roberto', 43300.00, 102),
(2, 'Tom', 56100.00, 103),
(3, 'Yana', 60200.00, 101);

INSERT INTO Passports (PassportID, PassportNumber) VALUES 
(101, 'N34FG21B'), 
(102, 'K65LO4R7'), 
(103, 'ZE657QP2');

ALTER TABLE Persons
	ADD CONSTRAINT PK_PersonID
PRIMARY KEY (PersonId) 

ALTER TABLE Passports
	ADD CONSTRAINT PK_PassportsId
PRIMARY KEY (PassportId) 

ALTER TABLE Persons
	ADD CONSTRAINT FK_PersonsPasspord
FOREIGN KEY (PassportID) REFERENCES Passports(PassportId);