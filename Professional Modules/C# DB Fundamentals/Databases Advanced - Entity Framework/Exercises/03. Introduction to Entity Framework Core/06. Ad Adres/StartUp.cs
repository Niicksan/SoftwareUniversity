using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;

namespace _6._Adding_a_New_Address_and_Updating_Employee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(AddNewAddressToEmployee(context));
            }
        }

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
    }
}