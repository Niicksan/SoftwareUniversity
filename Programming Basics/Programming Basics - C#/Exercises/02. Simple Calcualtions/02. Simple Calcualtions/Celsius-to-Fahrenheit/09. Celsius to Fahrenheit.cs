using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var Celsius = double.Parse(Console.ReadLine());
            var Fahrenheit = Celsius * 1.8 + 32;
            Console.WriteLine(Fahrenheit);
        }
    }
}
