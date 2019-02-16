SELECT 
  t.Id, 
  a.FirstName + ' ' + ISNULL(a.MiddleName + ' ', '') + a.LastName AS [Full Name],
  c.[Name] AS [From],
  hc.[Name] AS [TO],
  CASE 
	WHEN t.CancelDate IS NOT NULL THEN 'Canceled'
	ELSE CONVERT(VARCHAR(10), DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate)) + ' days'
  END AS Duration
	FROM Trips AS t
  JOIN Rooms AS r ON r.Id = t.RoomId
  JOIN Hotels AS h ON h.Id = r.HotelId
  JOIN Cities AS hc ON hc.Id = h.CityId
  JOIN AccountsTrips AS acct ON acct.TripId = t.Id
  JOIN Accounts AS a ON a.Id = acct.AccountId
  JOIN Cities AS c ON c.Id = a.CityId
ORDER BY [Full Name], t.Id;