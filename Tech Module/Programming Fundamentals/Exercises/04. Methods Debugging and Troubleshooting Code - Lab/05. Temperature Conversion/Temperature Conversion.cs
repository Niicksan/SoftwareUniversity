using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreeFahrenheit = double.Parse(Console.ReadLine());
            double degreeCelsius = FahrenheitToCelsiud(degreeFahrenheit);
            Console.WriteLine($"{degreeCelsius:F2}");
        }

        static double FahrenheitToCelsiud(double degreeFahrenheit)
        {
            double celsius = (degreeFahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
