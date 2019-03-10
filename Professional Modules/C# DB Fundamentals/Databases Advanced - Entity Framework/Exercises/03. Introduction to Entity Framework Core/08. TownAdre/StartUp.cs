using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;

namespace _08._Addresses_by_Town
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(GetAddressesByTown(context));
            }
        }

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
    }
}