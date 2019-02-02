SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID 
	FROM Employees AS e
	WHERE e.Salary > ( SELECT AVG(ed.Salary)
		FROM Employees AS ed
			WHERE e.DepartmentID = ed.DepartmentID)
ORDER BY e.DepartmentID;