SELECT e.EmployeeID, e.FirstName, e.LastName, d.Name
	FROM Employees AS e
  INNER JOIN Departments As d ON e.DepartmentID = d.DepartmentID
  WHERE e.DepartmentID = 3
  ORDER BY e.DepartmentID;