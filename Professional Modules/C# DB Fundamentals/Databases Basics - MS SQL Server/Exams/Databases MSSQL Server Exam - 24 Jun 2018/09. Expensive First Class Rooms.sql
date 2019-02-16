SELECT r.Id, r.Price, h.[Name] AS [Hotel], c.Name As [City]
	FROM Rooms as r
  INNER JOIN Hotels AS h ON h.Id = r.HotelId
  INNER JOIN Cities AS c ON c.Id = h.CityId
WHERE [Type] = 'First Class'
ORDER BY Price DESC, r.Id;
