SELECT 
  t.Id, h.[Name] AS [HotelName], 
  r.Type AS [RoomType], 
  Case
	WHEN t.CancelDate IS NOT NULL THEN 0.00
  ELSE
	SUM(h.BaseRate + r.Price) 
  END AS [Revenue]
	FROM Trips AS t
  INNER JOIN Rooms AS r ON r.id = t.RoomId
  INNER JOIN Hotels AS h ON h.Id = r.HotelId
  JOIN AccountsTrips AS acct ON acct.TripId = t.Id
GROUP BY t.Id, h.Name, r.Type, t.CancelDate
ORDER BY r.Type, t.Id;