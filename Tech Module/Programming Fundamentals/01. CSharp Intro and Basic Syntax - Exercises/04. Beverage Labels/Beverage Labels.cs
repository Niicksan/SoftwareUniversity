using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyContent = volume * (energy / 100);
            double sugarContent = volume * (sugar / 100);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
