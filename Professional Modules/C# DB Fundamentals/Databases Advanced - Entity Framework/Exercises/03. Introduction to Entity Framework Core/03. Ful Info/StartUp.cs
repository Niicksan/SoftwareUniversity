using System;
using SoftUni.Data;
using System.Linq;
using System.Text;

namespace _03._Employees_Full_Information
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            GetEmployeesFullInformation(context);

            using (context)
            {
                Console.WriteLine(GetEmployeesFullInformation(context));
            }
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] employees = context
                     .Employees
                     .OrderBy(e => e.EmployeeId)
                     .Select(e => $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F2}")
                     .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine(employee);
            }
            return sb.ToString();

        }
    }
}