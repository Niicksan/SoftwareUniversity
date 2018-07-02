using System;
using System.Linq;
using System.Numerics;

namespace _01._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLosses = 0;
            for (int i = 1; i <= numSites; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                string siteName = data[0];
                long siteVisits = long.Parse(data[1]);
                decimal pricePerVisit = decimal.Parse(data[2]);

                decimal num = siteVisits * pricePerVisit;

                totalLosses += num;

                Console.WriteLine(siteName);
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, numSites);

            Console.WriteLine($"Total Loss: {totalLosses:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
