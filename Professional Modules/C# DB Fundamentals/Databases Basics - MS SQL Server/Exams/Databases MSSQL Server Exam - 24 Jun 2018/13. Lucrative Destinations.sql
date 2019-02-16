SELECT TOP(10) c.Id, c.[Name], SUM(h.BaseRate + r.Price) AS [Total Revenue], COUNT(t.id) AS [Trips]
	FROM Cities AS c
  INNER JOIN Hotels AS h ON h.CityId = c.Id
  INNER JOIN Rooms AS r ON r.HotelId = h.Id
  INNER JOIN Trips AS t ON t.RoomId = r.Id
WHERE DATEPART(YEAR, BookDate) = 2016
GROUP BY c.Id, c.Name
ORDER BY [Total Revenue] DESC, [Trips] DESC;