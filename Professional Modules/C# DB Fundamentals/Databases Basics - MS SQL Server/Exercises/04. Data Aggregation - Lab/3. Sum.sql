SELECT e.DepartmentID,
		SUM(e.Salary) as TotalSalary
	FROM Employees AS e
GROUP BY e.DepartmentID;