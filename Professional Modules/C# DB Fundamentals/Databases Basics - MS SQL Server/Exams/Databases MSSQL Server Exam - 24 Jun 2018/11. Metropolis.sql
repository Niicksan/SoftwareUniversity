SELECT TOP(5) c.Id, c.[Name] AS City, c.CountryCode AS [County], COUNT(a.Id) AS COUNT
	FROM Cities As c
	INNER JOIN  Accounts AS a ON a.CityId = c.Id
GROUP BY c.Id, c.[Name], c.CountryCode
ORDER BY COUNT;