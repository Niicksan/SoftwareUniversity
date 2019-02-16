SELECT r.Id, r.Email, r.CountryCode, r.Trips
	FROM (
	SELECT a.Id, a.Email, c.CountryCode, COUNT(*) AS Trips,
	DENSE_RANK() OVER (PARTITION BY c.CountryCode ORDER BY COUNT(*) DESC, a.Id) AS TripsRank
		FROM Accounts AS a
	  INNER JOIN AccountsTrips AS acct ON acct.AccountId = a.Id
	  INNER JOIN Trips AS t ON t.Id = acct.TripId
	  INNER JOIN Rooms AS r ON r.Id = t.RoomId
	  INNER JOIN Hotels AS h ON h.id = r.HotelId
	  INNER JOIN Cities AS c ON c.Id = h.CityId
	GROUP BY c.CountryCode, a.Email, a.Id) AS r
WHERE r.TripsRank = 1
ORDER BY r.Trips DESC, r.Id ASC;
