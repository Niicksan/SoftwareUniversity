CREATE TABLE EmployeesProjects(  EmployeeID INT,  ProjectID INT,
  CONSTRAINT PK_EmployeesProjects
  PRIMARY KEY(EmployeeID, ProjectID),
  CONSTRAINT FK_EmployeesProjects_Employees
  FOREIGN KEY(EmployeeID)
  REFERENCES Employees(EmployeeID),
  CONSTRAINT FK_EmployeesProjects_Projects
  FOREIGN KEY(ProjectID)
  REFERENCES Projects(ProjectID)
)