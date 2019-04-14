--CREATE DATABASE School;

--1. DDL
CREATE TABLE Students  (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName  NVARCHAR(25),
	LastName NVARCHAR(30) NOT NULL,
	Age INT,
	[Address] NVARCHAR(50),
	Phone CHAR(10),
	CONSTRAINT CK_Age CHECK (Age >= 5 AND Age <= 100)
);

CREATE TABLE Subjects (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
	Lessons INT NOT NULL,
	CONSTRAINT CK_Lessons CHECK (Lessons > 0)
);

CREATE TABLE StudentsSubjects (
	Id INT PRIMARY KEY IDENTITY,
	StudentId INT FOREIGN KEY REFERENCES Students(Id) NOT NULL,
	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) NOT NULL,
	Grade DECIMAL(15, 2) NOT NULL,
	CONSTRAINT CK_StudentsSubjectsGrade CHECK (Grade >= 2.00 AND Grade <= 6.00)
);

CREATE TABLE Exams (
	Id INT PRIMARY KEY IDENTITY,
	[Date] DATETIME,
	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) NOT NULL,
);

CREATE TABLE StudentsExams (
	StudentId INT FOREIGN KEY REFERENCES Students(Id) NOT NULL,
	ExamId INT FOREIGN KEY REFERENCES Exams(Id) NOT NULL,
	Grade  DECIMAL(15, 2) NOT NULL,
	CONSTRAINT CK_StudentsExamsGrade CHECK (Grade >= 2.00 AND Grade <= 6.00),
	CONSTRAINT PK_StudentsExams PRIMARY KEY (StudentId, ExamId)
);

CREATE TABLE Teachers (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	[Address] NVARCHAR(20) NOT NULL,
	Phone CHAR(10),
	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) NOT NULL,
);

CREATE TABLE StudentsTeachers (
	StudentId INT FOREIGN KEY REFERENCES Students(Id) NOT NULL,
	TeacherId INT FOREIGN KEY REFERENCES Teachers(Id) NOT NULL,
	CONSTRAINT PK_StudentsTeachers PRIMARY KEY (StudentId, TeacherId)
);

--02. Insert
INSERT INTO Teachers (FirstName, LastName, [Address], Phone, SubjectId) VALUES
('Ruthanne', 'Bamb', '84948 Mesta Junction', '3105500146', 6),
('Gerrard', 'Lowin', '370 Talisman Plaza', '3324874824', 2),
('Merrile', 'Lambdin', '81 Dahle Plaza', '4373065154', 5),
('Bert', 'Ivie', '2 Gateway Circle', '4409584510', 4)

INSERT INTO Subjects ([Name], Lessons) VALUES 
('Geometry', 12),
('Health', 10),
('Drama', 7),
('Sports', 9)

--03. Update
UPDATE StudentsSubjects
SET Grade = 6.00
WHERE Grade >= 5.50 AND SubjectId IN (1, 2);

--04 Delete
ALTER TABLE StudentsTeachers DROP constraint FK_StudentsTeachers_Teachers
ALTER TABLE StudentsTeachers DROP constraint FK__Teachers__Subjec__5BE2A6F2

DELETE FROM Teachers
WHERE Phone LIKE '%72%';

--05. Teen Students
SELECT FirstName, LastName, age
	FROM Students
  WHERE Age >= 12
ORDER BY FirstName, LastName;

--06 Cool Addtess
SELECT FirstName + ' ' + ISNULL(MiddleName + ' ', ' ') + LastName AS FullName, [Address]
	FROM Students
  WHERE Address LIKE '%road%'
 ORDER BY FirstName, LastName, [Address];

--07. 42 Phones
SELECT FirstName, [Address], Phone
	FROM Students
  WHERE MiddleName IS NOT NULL AND Phone LIKE '42%'
ORDER BY FirstName;

--08. Students Teachers
SELECT s.FirstName, s.LastName, COUNT(st.TeacherId)
	FROM Students AS s
  INNER JOIN StudentsTeachers AS st ON st.StudentId = s.Id
GROUP BY s.FirstName, s.LastName;

--9. Subjects with Students
SELECT 
  FirstName + ' ' + LastName AS [FullName],
  s.[Name] + '-' +  CONVERT(NVARCHAR(10), s.Lessons) AS Subjects,
  COUNT(st.StudentId) AS [Students]
	FROM Teachers AS t
  INNER JOIN Subjects AS s ON s.Id = t.SubjectId
  INNER JOIN StudentsTeachers AS st ON st.TeacherId = t.Id
GROUP BY FirstName, LastName, s.[Name], s.Lessons
ORDER BY Students DESC;

--10. Students to Go
SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM Students As s
            LEFT JOIN StudentsExams AS se ON se.StudentId = s.Id
WHERE se.StudentId IS NULL
ORDER BY [Full Name];

--11. Busiest Teachers
SELECT TOP(10) FirstName, LastName, COUNT(st.StudentId) AS [StudentsCount]
	FROM Teachers As t
  INNER JOIN StudentsTeachers AS st ON st.TeacherId = t.Id
GROUP BY t.FirstName, t.LastName
ORDER BY [StudentsCount] DESC, FirstName, LastName;

--12. Top Students
SELECT DISTINCT TOP(10) s.FirstName, s.LastName, FORMAT(Round(AVG(se.Grade) OVER (PARTITION BY s.FirstName), 2), 'N') AS Grade
    FROM Students AS s 
  LEFT JOIN StudentsExams AS se ON se.StudentId = s.Id
ORDER BY Grade DESC, s.FirstName, s.LastName;


--13. Second Highest Grade
SELECT r.FirstName, r.LastName, r.Grade
    FROM(
    SELECT s.FirstName, s.LastName, FORMAT(Round(ss.Grade, 2), 'N') AS Grade,
    DENSE_RANK() OVER (PARTITION BY s.FirstName ORDER BY ss.Grade DESC) AS SecondGrade
      FROM Students AS s
      JOIN StudentsSubjects AS ss ON ss.StudentId = s.Id
    GROUP BY s.FirstName, s.LastName, ss.Grade) AS r
      WHERE r.SecondGrade = 2
      ORDER BY r.FirstName, r.LastName;


--14. Not So In The Studying
SELECT FirstName + ' ' + ISNULL(MiddleName + ' ', '') + LastName AS FullName
	FROM StudentsSubjects AS st
	INNER JOIN Subjects AS sub ON sub.Id = st.SubjectId
	RIGHT JOIN Students As s ON s.Id = st.StudentId
  WHERE st.StudentId IS NULL
 ORDER BY FullName;

--15. Top Student per Teacher
SELECT DISTINCT r.[Teacher Full Name], r.[Subject Name], r.[Student Full Name], r.Grade
    FROM (
    SELECT DISTINCT
	t.FirstName + ' ' + t.LastName AS [Teacher Full Name], 
	 sub.[Name] As [Subject Name], 
	s.FirstName + ' ' + s.LastName AS [Student Full Name],
	FORMAT(Round(AVG(stt.Grade), 2), 'n') AS Grade, 
    DENSE_RANK() OVER (PARTITION BY t.FirstName ORDER BY AVG(stt.Grade) DESC) AS FirstGrade
      FROM Teachers As t
		INNER JOIN Subjects AS sub ON sub.Id = t.SubjectId
		INNER JOIN StudentsTeachers AS st ON st.TeacherId = t.Id
		INNER JOIN Students AS s ON s.Id = st.StudentId
		INNER JOIN StudentsSubjects AS stt ON stt.StudentId = s.Id
    GROUP BY t.FirstName, t.LastName, sub.[Name], s.FirstName, s.LastName, stt.Grade) AS r
  WHERE r.FirstGrade = 1
  ORDER BY r.[Subject Name], r.[Teacher Full Name], r.Grade DESC;

--16. Average Grade per Subject
SELECT sub.Name, AVG(ss.Grade)
	FROM 
	Subjects AS sub
  INNER JOIN StudentsSubjects AS ss ON ss.SubjectId = sub.Id
GROUP BY sub.Name, sub.Id
ORDER BY sub.Id;

--17. Exams Information
SELECT t.Id, a.FirstName +' '+ ISNULL(a.MiddleName+' ', '') + LastName AS FullName,
c.Name AS [From],
hc.Name AS [To],
CASE
WHEN t.CancelDate IS NOT NULL THEN 'Canceled'
ELSE CONVERT(VARCHAR(10),DATEDIFF(DAY, ArrivalDate, ReturnDate)) + ' days' 
END AS Duration
 FROM Trips AS t
 JOIN Rooms AS r
 ON r.Id = t.RoomId
 JOIN Hotels AS h
 ON h.Id = r.HotelId
 JOIN Cities AS hc
 ON hc.Id = h.CityId
JOIN AccountsTrips AS at
ON at.TripId = t.Id
JOIN Accounts AS a
ON a.Id = at.AccountId
JOIN Cities AS c
ON c.Id = a.CityId
ORDER BY FullName, t.Id

--18. Exam Grades
SELECT dbo.udf_GetAvailableRoom(112, '2011-12-17', 2)
SELECT dbo.udf_GetAvailableRoom(94, '2015-07-26', 3)

ALTER FUNCTION udf_GetAvailableRoom(@HotelId INT, @Date DATETIME2, @People INT) RETURNS VARCHAR(MAX)
AS BEGIN
   DECLARE @AvailableRoom NVARCHAR(MAX)= (SELECT TOP(1) CONCAT('Room ', r.Id, ': ', r.Type,' (', r.Beds, ' beds) - $', (h.BaseRate + r.Price) * @People)
                  FROM Hotels AS h
                  JOIN Rooms AS r
                  ON r.HotelId = h.Id
                  JOIN Trips AS t
                  ON t.RoomId = r.Id
                  WHERE @Date NOT BETWEEN t.ArrivalDate AND t.ReturnDate 
                  AND h.Id = @HotelId AND r.Beds > @People
				  AND t.CancelDate IS NULL
                  ORDER BY r.Price DESC)

		IF(@AvailableRoom IS NULL)
		BEGIN
		   RETURN 'No rooms available' 
		END 
		
		  RETURN @AvailableRoom	
END

--19. Exclude from school
GO

CREATE PROCEDURE usp_ExcludeFromSchool(@StudentId INT)
AS
	BEGIN
 
	DECLARE @CurrentStudentId INT = (SELECT s.Id
                               FROM Students AS s
                               WHERE s.Id = @StudentId)
	IF(@CurrentStudentId IS NULL)
		BEGIN
			RAISERROR('This school has no student with the provided id', 16, 1)
		RETURN
	END

	ALTER TABLE StudentsSubjects DROP constraint FK__StudentsS__Stude__4F7CD00D
	ALTER TABLE StudentsExams DROP constraint FK__StudentsE__Stude__571DF1D5

	DELETE Students
		WHERE @CurrentStudentId = @StudentId
END

EXEC usp_ExcludeFromSchool 1
SELECT COUNT(*) FROM Students

--20
CREATE TRIGGER tr_ExcludedStudents ON Students
INSTEAD OF DELETE
AS
UPDATE Students
SET CancelDate = GETDATE()
WHERE Id IN (SELECT Id FROM deleted WHERE CancelDate IS NULL)