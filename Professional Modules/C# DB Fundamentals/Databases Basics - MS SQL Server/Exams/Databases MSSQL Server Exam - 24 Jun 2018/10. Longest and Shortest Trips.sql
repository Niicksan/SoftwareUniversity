SELECT 
	a.Id AS [AccountId], FirstName + ' ' + LastName As [FullName], 
	MAX(DATEDIFF(Day, ArrivalDate, ReturnDate)) AS LongestTrip,
	MIN(DATEDIFF(DAY, ArrivalDate, ReturnDate)) AS ShortestTrip
	FROM Accounts AS a
  INNER JOIN AccountsTrips AS ac ON ac.AccountId = a.Id
  INNER JOIN Trips AS t ON t.Id = ac.TripId
WHERE a.MiddleName IS NULL  AND t.CancelDate IS NULL
GROUP BY a.Id, a.FirstName + ' ' + a.LastName, AccountId
ORDER BY LongestTrip DESC, a.Id;