CREATE DATABASE Movies;

CREATE TABLE Directors (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	DirectorName NVARCHAR(100) NOT NULL,
	Notes TEXT
)

CREATE TABLE Genres (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	GenreName NVARCHAR(100) NOT NULL,
	Notes TEXT
)

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	CategoryName NVARCHAR(100) NOT NULL,
	Notes TEXT
)

CREATE TABLE Movies (
	Id INT PRIMARY KEY IDENTITY  NOT NULL,
	Title NVARCHAR(100) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors (Id) NOT NULL,
	CopyrightYear INT NOT NULL,
    [Length] TIME NOT NULL,
	GenreId INT FOREIGN KEY REFERENCES Genres (Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories (Id) NOT NULL,
	Rating INT,
	Notes TEXT
)

INSERT INTO Directors(DirectorName,Notes) VALUES 
('Георги', 'Пешо е добър режисьор'), 
('Митко','Митко е най-добрия в специалните ефекти'),
('Ник', 'Отличен режисьор'),
('Калина', 'Тя просто е перфектна в работата си'),
('Дима', 'Добра монтажистка')

INSERT INTO Genres (GenreName, Notes) VALUES 
('Action', 'екшън'),
('Drama', 'драма'),
('Comedy', 'комедия'),
('Horror', 'ужаси'),
('Thriller', 'трилър')

INSERT INTO Categories (CategoryName,Notes) VALUES 
('Best movies', 'Отличен филм'),
('Best role', 'Най - добра роля'),
('Movie of the year','Филм на годината'),
('Drama', 'драма' ),
('Thriller', 'Най - добър трилър')

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) VALUES
('King if the England', 5, 1999, '01:23:00', 1, 5, 10, 'Фантастичен'),
('Travelling through the oceon', 4, 2000, '02:14:00', 2, 4, 9, 'Отличен'),
('A book', 3, 2015, '01:48:00', 3, 3, 5,'Много смешен'),
('Anabel', 2, 2005, '01:55:00', 4, 2, 10,'Страшен'),
('The seller', 1, 2018, '02:10:00', 5, 1, 10, 'Много кръв')