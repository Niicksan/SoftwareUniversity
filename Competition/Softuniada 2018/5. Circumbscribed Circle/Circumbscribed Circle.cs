using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Circumbscribed_Circle
{
    class Program
    {
        public const double Epsilon = 0.01;

        private static Triangle triangle;
        private static Circle circle;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                ReadFigures();;
                bool bottomLeftInsideCircle = circle.IsInsideCircle(triangle.BottomLeft);
                bool bottomRightInsideCircle = circle.IsInsideCircle(triangle.BottomRight);
                bool topInsideCircle = circle.IsInsideCircle(triangle.Top);

                bool topInsideTriangle = triangle.IsInsideRectangle(circle.Top);
                bool rightInsideTriangle = triangle.IsInsideRectangle(circle.Right);
                bool bottomInsideTriangle = trianglee.IsInsideRectangle(circle.Bottom);
                bool leftInsideTriangle = triangle.IsInsideRectangle(circle.Left);

                if (bottomLeftInsideCircle && bottomRightInsideCircle && topInsideCircle)
                {

                }
            }

        }

        private static void ReadFigures()
        {
            for (int i = 0; i < 2; i++)
            {
                string[] figureParts = Console.ReadLine().Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public class Point
        {
            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }

            public double X { get; private set; }

            public double Y { get; private set; }
        }

        public class Circle
        {
            public Circle(Point center, double radius)
            {
                this.Center = center;
                this.Radius = radius;
                this.Top = new Point(center.X, center.Y + radius);
                this.Right = new Point(center.X + radius, center.Y);
                this.Bottom = new Point(center.X, center.Y - radius);
                this.Left = new Point(center.X - radius, center.Y);
            }

            public Point Center { get; private set; }

            public double Radius { get; set; }

            public Point Top { get; private set; }

            public Point Right { get; private set; }

            public Point Bottom { get; private set; }

            public Point Left { get; private set; }

            public static Circle Parse(string circleString)
            {
                double[] circleCoordinates = circleString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                return new Circle(new Point(circleCoordinates[0], circleCoordinates[1]), circleCoordinates[2]);
            }

            public bool IsInsideCircle(Point point)
            {
                return (point.X - this.Center.X) * (point.X - this.Center.X) + (point.Y - this.Center.Y) * (point.Y - this.Center.Y) - this.Radius * this.Radius <= CrossingFigures.Epsilon;
            }
        }

        public class Triangle
        {
            public Triangle(Point bottomLeft, Point bottomRight, Point top)
            {
                this.BottomLeft = bottomLeft;
                this.BottomRight = bottomRight;
                this.Top = top;
            }

            public Point BottomLeft { get; private set; }

            public Point BottomRight { get; private set; }

            public Point Top { get; private set; }


            public static Triangle Parse(string rectangleString)
            {
                double[] triangleCoordinates = rectangleString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                return new Triangle(
                    new Point(triangleCoordinates[0], triangleCoordinates[1]),
                    new Point(triangleCoordinates[2], triangleCoordinates[3]),
                    new Point(triangleCoordinates[4], triangleCoordinates[5]));
            }

            public bool centerInside (Point point)
            {
                return point.X < this.BottomRight.X && point.X > this.BottomLeft.X &&
                    point.Y < this.Top.Y && point.Y > BottomLeft.Y;
            }

            public bool centerBorder(Point point)
            {
                return point.X == this.BottomRight.X || point.X == this.BottomLeft.X ||
                    point.Y == this.Top.Y || point.Y == BottomLeft.Y;
            }

            public bool circumbscribed(Point point)
            {
                return point.X < this.BottomRight.X && point.X > this.BottomLeft.X &&
                    point.Y < this.Top.Y && point.Y > BottomLeft.Y;
            }
        }
    }
}