using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _09._Employee_147
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(GetEmployee147(context));
            }
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context
                .Employees
                .Find(147);

            var projects = context
                .EmployeesProjects
                .Where(p => p.EmployeeId == 147)
                .Select(p => new
                {
                    projectName = p.Project.Name,
                })
                .OrderBy(p => p.projectName)
                .ToList();

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in projects)
            {
                sb.AppendLine($"{project.projectName}");
            }

            return sb.ToString();
        }
    }
}