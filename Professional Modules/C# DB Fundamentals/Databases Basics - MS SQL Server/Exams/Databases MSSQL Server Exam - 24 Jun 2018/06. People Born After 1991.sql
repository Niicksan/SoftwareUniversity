SELECT 
  FirstName + ' ' + ISNULL(MiddleName + ' ', '') + LastName AS [Full Name], 
  DATEPART(YEAR, BirthDate) AS [BirthYear]
	FROM Accounts
 WHERE DATEPART(YEAR, BirthDate) > 1991
ORDER BY BirthYear DESC, [Full Name];