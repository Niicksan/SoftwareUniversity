using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = GeometryCalculator(figure);

            Console.WriteLine($"{area:F2}");
        }

        private static double GeometryCalculator(string figure)
        {
            double area = 0;

            switch (figure)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = triangleSide * triangleHeight / 2;
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    area = Math.Pow(squareSide, 2);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = width * height;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    break;
            }

            return area;
        }
    }
}
