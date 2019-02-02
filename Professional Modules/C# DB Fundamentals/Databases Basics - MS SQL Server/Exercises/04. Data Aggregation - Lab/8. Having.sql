SELECT e.DepartmentID,
		SUM(e.Salary) AS TotalSalary
	FROM Employees AS e
GROUP BY e.DepartmentID
	HAVING SUM(e.Salary) >= 15000;