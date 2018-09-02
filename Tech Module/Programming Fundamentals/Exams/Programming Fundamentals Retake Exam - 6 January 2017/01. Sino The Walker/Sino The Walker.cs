using System;
using System.Globalization;
using System.Linq;

namespace _01._Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long steps = long.Parse(Console.ReadLine()) % 86400;
            long seconds = long.Parse(Console.ReadLine()) % 86400;

            long timeSeconds = steps * seconds;

            date = date.AddSeconds(timeSeconds);

            Console.WriteLine($"Time Arrival: {date.Hour:d2}:{date.Minute:d2}:{date.Second:d2}");
        }
    }
}
