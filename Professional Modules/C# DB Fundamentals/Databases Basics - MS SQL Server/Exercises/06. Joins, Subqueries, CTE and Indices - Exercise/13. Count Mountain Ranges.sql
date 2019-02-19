SELECT mc.CountryCode, COUNT(mc.CountryCode)
	FROM MountainsCountries AS mc
  INNER JOIN Mountains AS m ON m.Id = mc.MountainId
WHERE CountryCode IN ('BG', 'US', 'RU')
GROUP BY mc.CountryCode;