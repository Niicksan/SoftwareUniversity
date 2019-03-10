using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace _15._Remove_Town
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                Console.WriteLine(RemoveTown(context));
            }
        }

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