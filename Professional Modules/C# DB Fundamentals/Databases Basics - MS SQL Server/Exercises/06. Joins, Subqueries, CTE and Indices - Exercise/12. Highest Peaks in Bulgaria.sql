SELECT mc.CountryCode, m.MountainRange, p.PeakName, p.Elevation
	FROM Mountains as m
  INNER JOIN Peaks AS p ON m.Id = p.MountainId
  INNER JOIN MountainsCountries AS mc ON m.Id = mc.MountainId
WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC;