using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();

            var resultMaxAvSalary = employees
                    .GroupBy(e => e.Department)
                    .Select(d => new
                    {
                        Department = d.Key,
                        AvSalary = d.Average(emp => emp.Salary),
                        Employees = d.OrderByDescending(emp => emp.Salary).ToList()
                    })
                    .OrderByDescending(d => d.AvSalary)
                    .FirstOrDefault();

            if (resultMaxAvSalary != null)
            {
                Console.WriteLine($"Highest Average Salary: {resultMaxAvSalary.Department}");
                resultMaxAvSalary.Employees
                                 .ForEach(e => Console.WriteLine(e.ToString()));
            }
        }

        private static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            int employeesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeesNumber; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string position = employeeInfo[2];
                string department = employeeInfo[3];

                Employee employee = new Employee(name, salary, position, department);

                if (employeeInfo.Length > 4)
                {
                    string emailOrAge = employeeInfo[4];
                    if (emailOrAge.Contains("@"))
                    {
                        employee.Email = emailOrAge;
                    }
                    else
                    {
                        employee.Age = int.Parse(emailOrAge);
                    }
                }

                if (employeeInfo.Length > 5)
                {
                    int age = int.Parse(employeeInfo[5]);

                    employee.Age = age;
                }

                employees.Add(employee);
            }

            return employees;
        }
    }
}