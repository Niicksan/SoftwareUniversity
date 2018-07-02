using System;

namespace _01._Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double totalDistance = (wingFlaps / 1000) * distance;
            double secondsForDistance = wingFlaps / 100;
            double totalSeconds = secondsForDistance + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");
         }
    }
}
