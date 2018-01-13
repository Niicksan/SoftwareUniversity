using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2.0;
            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
