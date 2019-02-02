SELECT e.DepartmentID,
		MIN(e.Salary) AS MinSalary
	FROM Employees As e
GROUP BY e.DepartmentID;