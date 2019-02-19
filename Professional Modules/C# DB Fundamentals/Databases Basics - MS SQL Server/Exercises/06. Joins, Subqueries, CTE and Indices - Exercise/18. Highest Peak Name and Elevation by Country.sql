SELECT TOP(5) 
  WITH TIES c.CountryName, 
  ISNULL(p.PeakName, '(no highest peak)') AS 'HighestPeakName', 
  ISNULL(MAX(p.Elevation), 0) AS'HoghestPeakElevation', 
  ISNULL(m.MountainRange, '(no mountin)')
	FROM Countries As c
  LEFT JOIN MountainsCountries As mc On c.CountryCode = mc.CountryCode
  LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
  LEFT JOIN Peaks As p ON m.Id = p.MountainId
GROUP BY c.CountryName, p.PeakName, m.MountainRange
ORDER BY c.CountryName, p.PeakName;
