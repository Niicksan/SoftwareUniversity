SELECT
  MIN(a.AverageSalary) AS MinAverageSalary
  FROM 
  (
     SELECT e.DepartmentID, 
            AVG(e.Salary) AS AverageSalary
       FROM Employees AS e
   GROUP BY e.DepartmentID
  ) AS a;


--SELECT TOP (1)
--  (SELECT AVG(Salary)) AS [MinAverageSalary]
--	FROM Employees
--GROUP BY [DepartmentID]
--ORDER BY [MinAverageSalary];