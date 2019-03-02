using MiniORM.App.Data;
using MiniORM.App.Data.Entities;
using System.Linq;

namespace MiniORM.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = MiniORM; Integrated Security = true";

            var context = new SoftUniDbContext(connectionString);

            context.Employees.Add(new Employee
            {
                FirstName = "Emilia",
                LastName = "Nedialkova",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true,
            });

            var employee = context.Employees.Last();

            context.SaveChanges();

            //Test
            System.Console.WriteLine($"First Name:{employee.FirstName}, Last Name:{employee.LastName}");
        }
    }
}
