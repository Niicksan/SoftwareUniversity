using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _12._Increase_Salaries
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(IncreaseSalaries(context));
            }
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] dep = { "Engineering", "Tool Design", "Marketing", "Information Services" };

            var employees = context
                .Employees
                .Where(e => dep.Contains(e.Department.Name))
                .OrderBy(e => e.FirstName)
                .ThenBy(x => x.LastName)
                .ToArray();

            foreach (var emp in employees)
            {
                emp.Salary *= 1.12m;
            }

            context.SaveChanges();

            foreach (var emp in employees)
            {
                sb.AppendLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f2})");
            }

            return sb.ToString();
        }
    }
}