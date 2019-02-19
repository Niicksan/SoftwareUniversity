SELECT TOP(5) 
  c.CountryName, 
  MAX(p.Elevation) AS [HighestPeakElevation], 
  MAX(r.Length) AS [LongestRiverLength]
	FROM Countries AS c
  LEFT OUTER JOIN MountainsCountries As mc ON c.CountryCode = mc.CountryCode
  LEFT OUTER JOIN Peaks As p ON p.MountainId = mc.MountainId
  LEFT OUTER JOIN CountriesRivers As cr ON c.CountryCode = cr.CountryCode
  LEFT OUTER JOIN Rivers As r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY [HighestPeakElevation] DESC, [LongestRiverLength] DESC, c.CountryName;