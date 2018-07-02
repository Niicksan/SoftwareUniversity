using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double totalSeconds = seconds + (hours * 3600) + (minutes * 60);
            double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            double metersPerSecond = meters / totalSeconds;
            double kilometersPerHours = (meters / 1000.0) / totalHours;
            double milesPerHours = ((double)meters / 1609.0) / totalHours;

            Console.WriteLine($"{metersPerSecond:F6}");
            Console.WriteLine($"{kilometersPerHours:F6}");
            Console.WriteLine($"{milesPerHours:F6}");
        }
    }
}