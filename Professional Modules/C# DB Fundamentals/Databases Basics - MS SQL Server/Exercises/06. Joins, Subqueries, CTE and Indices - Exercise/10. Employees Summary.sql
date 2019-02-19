SELECT TOP(50)
  e.EmployeeID, 
  e.FirstName + ' ' + e.LastName AS [EmployeeName], 
  m.FirstName + ' ' + m.LastName AS [ManagerName],
  d.[Name] AS [DepartmentName] 
	FROM Employees AS e
  INNER JOIN Employees As m ON m.ManagerID = e.EmployeeID
  INNER JOIN Departments As d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID;