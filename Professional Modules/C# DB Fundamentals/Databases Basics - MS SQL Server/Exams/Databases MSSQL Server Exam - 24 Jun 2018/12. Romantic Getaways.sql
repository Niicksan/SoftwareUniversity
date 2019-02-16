SELECT a.Id, a.Email, c.[Name] AS [City], COUNT(t.Id) AS [Trips]
	FROM Accounts As a
  INNER JOIN AccountsTrips AS acct ON acct.AccountId = a.Id
  INNER JOIN Trips AS t ON t.Id = acct.TripId
  INNER JOIN Rooms AS r ON r.Id = t.RoomId
  INNER JOIN Hotels AS h ON h.id = r.HotelId
  INNER JOIN Cities AS c ON c.Id = h.CityId
WHERE c.Id = a.CityId
GROUP BY a.Id, a.Email, c.Name
ORDER BY Trips DESC, a.Id;