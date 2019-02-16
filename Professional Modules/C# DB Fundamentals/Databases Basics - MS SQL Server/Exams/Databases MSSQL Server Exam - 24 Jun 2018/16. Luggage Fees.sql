SELECT 
  TripId, 
  SUM(Luggage) AS Luggage,
  '$' + CONVERT(VARCHAR(10), 
  SUM(Luggage) * 
	CASE 
		WHEN SUM(Luggage) > 5 THEN 5
		ELSE 0
	END) AS Fee
	FROM Trips
  JOIN AccountsTrips AS [at] ON Trips.Id = at.TripId
GROUP BY TripId
HAVING SUM(Luggage) > 0
ORDER BY Luggage DESC;   