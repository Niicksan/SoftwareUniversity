SELECT 
	Id, 
    FirstName + ' ' + LastName AS [FullName], 
    UCN AS [Ucn] 
	FROM Colonists
ORDER BY FirstName, LastName, Id;