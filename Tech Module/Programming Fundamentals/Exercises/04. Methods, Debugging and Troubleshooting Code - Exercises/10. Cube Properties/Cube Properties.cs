using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = FindpropertiesOfTheCube(side, parameter);
            Console.WriteLine($"{result:F2}");
        }

        private static double FindpropertiesOfTheCube(double side, string parameter)
        {
            double result = 0.0;

            switch (parameter)
            {
                case "face":
                    result = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2));
                    break;
                case "space":
                    result = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2) + Math.Pow(side, 2));
                    break;
                case "volume":
                    result = Math.Pow(side, 3);
                    break;
                case "area":
                    result = Math.Pow(side, 2) * 6;
                    break;
            }

            return result;
        }
    }
}
