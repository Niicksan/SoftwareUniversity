using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _10._Departments_with_More_Than_5_Employees
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));
            }
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departments = context
                .Departments
                .Where(e => e.Employees.Count() > 5)
                .OrderBy(e => e.Employees.Count())
                .ThenBy(d => d.Name)
                .Select(x => new
                {
                    DepartmentName = x.Name,
                    ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                    Employee = x.Employees.Select(e => new
                    {
                        EmployeeName = e.FirstName + " " + e.LastName,
                        EmployeeLastName = e.LastName,
                        JobTitle = e.JobTitle
                    })
                })
                 .ToArray();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.DepartmentName} - {department.ManagerName}");
                foreach (var employee in department.Employee.OrderBy(e => e.EmployeeName).ThenBy(e => e.EmployeeLastName))
                {
                    sb.AppendLine($"{employee.EmployeeName} - {employee.JobTitle}");
                }
            }

            return sb.ToString();
        }
    }
}