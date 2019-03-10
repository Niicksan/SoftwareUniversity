using SoftUni.Data;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _07._Employees_and_Projects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(GetEmployeesInPeriod(context));
            }
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var empoyees = context
                .Employees
                .Where(ep => ep.EmployeesProjects.Any(y => y.Project.StartDate.Year >= 2001) && ep.EmployeesProjects.Any(y => y.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    EmployeeFullName = x.FirstName + " " + x.LastName,
                    ManagerFllName = x.Manager.FirstName + " " + x.Manager.LastName,
                    Projects = x.EmployeesProjects.Select(p => new
                    {
                        ProjectName = p.Project.Name,
                        StartDate = p.Project.StartDate,
                        EndDate = p.Project.EndDate
                    })
                })
                .Take(10)
                .ToArray();

            string format = "M/d/yyyy h:mm:ss tt";

            foreach (var empoyee in empoyees)
            {
                sb.AppendLine($"{empoyee.EmployeeFullName} - Manager: {empoyee.ManagerFllName}");

                foreach (var project in empoyee.Projects)
                {
                    string startDate = project.StartDate.ToString(format, CultureInfo.InvariantCulture);
                    string endDate = "";

                    if (project.EndDate.HasValue)
                    {
                        endDate = project.EndDate.Value.ToString(format, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        endDate = "not finished";
                    }

                    sb.AppendLine($"--{project.ProjectName} - {startDate} - {endDate}");
                }
            }

            return sb.ToString();
        }
    }
}