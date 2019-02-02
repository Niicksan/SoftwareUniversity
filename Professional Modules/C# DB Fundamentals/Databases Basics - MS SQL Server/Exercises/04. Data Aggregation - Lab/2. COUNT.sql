SELECT e.DepartmentID, 
         COUNT(e.Salary) AS SalaryCount
    FROM Employees AS e
GROUP BY e.DepartmentID;