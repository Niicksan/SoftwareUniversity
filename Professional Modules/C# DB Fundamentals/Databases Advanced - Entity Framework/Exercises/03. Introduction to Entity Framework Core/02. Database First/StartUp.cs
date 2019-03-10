using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                // 03. Employees Full Information
                //Console.WriteLine(GetEmployeesFullInformation(context));

                // 04.Employees with Salary Over 50 000
                //Console.WriteLine(GetEmployeesWithSalaryOver50000(context));

                //05. Employees from Research and Development
                //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context));

                //06.Adding a New Address and Updating Employee
                //Console.WriteLine(AddNewAddressToEmployee(context));

                //07. Employees and Projects
                //Console.WriteLine(GetEmployeesInPeriod(context));

                //08. Addresses by Town 
                //Console.WriteLine(GetAddressesByTown(context));

                //09.Employee 147
                //Console.WriteLine(GetEmployee147(context));

                //10. Departments with More Than 5 Employees 
                //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));

                //11. Find Latest 10 Projects
                //Console.WriteLine(GetLatestProjects(context));

                //12. Increase Salaries
                //Console.WriteLine(IncreaseSalaries(context));

                //13. Find Employees by First Name Starting With Sa
                //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));

                //14. Delete Project by Id
                //Console.WriteLine(DeleteProjectById(context));

                //15. Remove Town
                Console.WriteLine(RemoveTown(context));
            }
        }

        // 03. Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] employees = context
                     .Employees
                     .OrderBy(e => e.EmployeeId)
                     .Select(e => $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}")
                     .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine(employee);
            }

            return sb.ToString();
        }

        // 04. Employees with Salary Over 50 000
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

        //05. Employees from Research and Development
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

        //06. Adding a New Address and Updating Employee
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            Address address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            Employee nakov = context
                .Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            nakov.Address = address;
            context.SaveChanges();

            string[] employees = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine(employee);
            }

            return sb.ToString();
        }

        //07. Employees and Projects
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

        // 08. Addresses by Town
        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses
                .OrderByDescending(x => x.Employees.Count())
                .ThenBy(x => x.Town.Name)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .Select(a => new
                {
                    AddressText = a.AddressText,
                    Town = a.Town.Name,
                    EmployeesCount = a.Employees.Count
                })
                .ToArray();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.AddressText}, {address.Town} - {address.EmployeesCount} employees");
            }

            return sb.ToString();
        }

        //09. Employee 147
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

        //10. Departments with More Than 5 Employees 
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

        //11. Find Latest 10 Projects
        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var projects = context
                .Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .ToArray();

            foreach (var project in projects)
            {
                sb.AppendLine($"{project.Name}");
                sb.AppendLine($"{project.Description}");
                sb.AppendLine($"{project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
            }

            return sb.ToString();
        }

        //12. Increase Salaries
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

        //13. Find Employees by First Name Starting With Sa
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
            }

            return sb.ToString();
        }

        //14. Delete Project by Id
        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var project = context.Projects.Find(2);

            var employees = context
                .Employees
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .ToList();

            foreach (var employee in employees)
            {
                foreach (var employeeProject in employee.EmployeesProjects.ToList())
                {
                    if (employeeProject.Project.Equals(project))
                    {
                        employee.EmployeesProjects.Remove(employeeProject);
                    }
                }
            }

            context.Projects.Remove(project);

            context.SaveChanges();

            var projects = context.Projects.Select(x => x.Name).Take(10).ToList();
            projects.ForEach(x => sb.AppendLine(x));

            return sb.ToString().Trim();
        }

        //15. Remove Town
        public static string RemoveTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string townName = "Seattle";

            context.Employees
                .Where(e => e.Address.Town.Name == townName)
                .ToList()
                .ForEach(e => e.AddressId = null);

            int addressesCount = context.Addresses
                .Where(a => a.Town.Name == townName)
                .Count();

            context.Addresses
                .Where(a => a.Town.Name == townName)
                .ToList()
                .ForEach(a => context.Addresses.Remove(a));

            context.Towns
                .Remove(context.Towns
                    .SingleOrDefault(t => t.Name == townName));

            context.SaveChanges();

            sb.AppendLine($"{addressesCount} {(addressesCount == 1 ? "address" : "addresses")} in {townName} {(addressesCount == 1 ? "was" : "were")} deleted");

            return sb.ToString();
        }
    }
}