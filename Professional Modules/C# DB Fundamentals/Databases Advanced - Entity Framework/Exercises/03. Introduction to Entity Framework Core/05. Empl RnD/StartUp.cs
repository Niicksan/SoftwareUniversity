using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _05._Employees_from_Research_and_Development
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context));
            }
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] employees = context
                .Employees
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => $"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:f2}")
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee}");
            }

            return sb.ToString();
        }
    }
}