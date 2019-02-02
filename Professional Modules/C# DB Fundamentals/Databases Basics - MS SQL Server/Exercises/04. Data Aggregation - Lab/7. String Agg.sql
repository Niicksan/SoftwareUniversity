SELECT JobTitle, 
	STRING_AGG(Salary, ', ') WITHIN GROUP
		(ORDER BY Salary) AS Salry
	FROM Employees
GROUP BY JobTitle