using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfCakesNeeded = int.Parse(Console.ReadLine());
            decimal kgFlourNeededPerCake = decimal.Parse(Console.ReadLine());
            ulong kgFlourAvailable = ulong.Parse(Console.ReadLine());
            ulong amountOfTruffles = ulong.Parse(Console.ReadLine());
            ulong pricePerTruffles = ulong.Parse(Console.ReadLine());

            decimal amountOfCakes = Math.Floor(kgFlourAvailable / kgFlourNeededPerCake);
            decimal priceOfAllTruffles = amountOfTruffles * pricePerTruffles;
            decimal pricePerCake = (priceOfAllTruffles / amountOfCakesNeeded) * 1.25m;

            decimal kgFlourMoreNeeded = (amountOfCakesNeeded * kgFlourNeededPerCake) - kgFlourAvailable;

            if (amountOfCakes >= amountOfCakesNeeded)
            {
                Console.WriteLine($"All products available, price of a cake: {pricePerCake:f2}");
            }
            else
            {
                Console.WriteLine($"Can make only {amountOfCakes} cakes, need {kgFlourMoreNeeded:f2} kg more flour");
            }
        }
    }
}
