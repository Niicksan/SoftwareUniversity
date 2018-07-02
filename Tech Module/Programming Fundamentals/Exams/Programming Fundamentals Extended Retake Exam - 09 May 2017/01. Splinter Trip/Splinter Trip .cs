using System;

namespace _01._Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDistance = double.Parse(Console.ReadLine());
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            double milesInHeavyWinds = double.Parse(Console.ReadLine());

            double fuelNeeded = ((tripDistance - milesInHeavyWinds) * 25) + (milesInHeavyWinds * (25 * 1.5));
            double totalFuelNeeded = fuelNeeded + (fuelNeeded * 0.05);

            double remainingFuel = Math.Abs(fuelTankCapacity - totalFuelNeeded);
            if (totalFuelNeeded <= fuelTankCapacity)
            {
                Console.WriteLine($"Fuel needed: {totalFuelNeeded:F2}L");
                Console.WriteLine($"Enough with {remainingFuel:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"Fuel needed: {totalFuelNeeded:F2}L");
                Console.WriteLine($"We need {remainingFuel:F2}L more fuel.");
            }
        }
    }
}
