using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _04._Employees_with_Salary_Over_50_000
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(GetEmployeesWithSalaryOver50000(context));
            }
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] employees = context
                .Employees
                .OrderBy(e => e.FirstName)
                .Where(e => e.Salary > 50000)
                .Select(e => $"{e.FirstName} - {e.Salary:f2}")
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee}");
            }

            return sb.ToString();
        }
    }
}