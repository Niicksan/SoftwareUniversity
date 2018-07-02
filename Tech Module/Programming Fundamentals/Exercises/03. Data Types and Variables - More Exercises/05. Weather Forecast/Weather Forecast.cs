using System;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            string weather = "";

            if (number % 1 != 0)
            {
                weather = "Rainy";
            }
            else if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                weather = "Sunny";
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                weather = "Cloudy";
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                weather = "Windy";
            }
           
            Console.WriteLine(weather);
        }
    }
}
