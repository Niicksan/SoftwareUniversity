using System;
using System.Linq;

namespace _03._Circles_Intersection
{
    class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }

    class Circle
    {
        public Circle(Point point, double radius)
        {

            Point = point;
            Radius = radius;
        }

        public Point Point { get; set; }
        public double Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] circle1Data = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double circle1X = circle1Data[0];
            double circle1Y = circle1Data[1];
            double circle1Radius = circle1Data[2];

            Point point1 = new Point(circle1X, circle1Y);
            Circle circle1 = new Circle(point1, circle1Radius);

            double[] circle2Data = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double circle2X = circle2Data[0];
            double circle2Y = circle2Data[1];
            double circle2Radius = circle2Data[2];

            Point point2 = new Point(circle2X, circle2Y);
            Circle circle2 = new Circle(point2, circle2Radius);

            double distance = Math.Sqrt(Math.Pow(circle2.Point.X - circle1.Point.X, 2) +
                Math.Pow(circle2.Point.Y - circle1.Point.Y, 2));

            bool isIntersect = distance <= circle1.Radius + circle2.Radius;

            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
