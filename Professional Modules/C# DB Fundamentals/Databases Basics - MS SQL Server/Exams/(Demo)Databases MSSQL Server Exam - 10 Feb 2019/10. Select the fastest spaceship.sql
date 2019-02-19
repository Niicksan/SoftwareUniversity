SELECT TOP(1) sc.[Name] AS [SpaceshipName], sp.[Name] AS [SpaceportName]
	FROM Spaceships AS sc
  INNER JOIN Journeys AS j ON j.SpaceshipId = sc.Id
  INNER JOIN Spaceports As sp ON sp.Id = j.DestinationSpaceportId
ORDER BY LightSpeedRate DESC
