using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangleCoordinates = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int topLeftPointX = rectangleCoordinates[0];
            int topLeftPointY = rectangleCoordinates[1];

            int bottomRightPointX = rectangleCoordinates[2];
            int bottomRightPointY = rectangleCoordinates[3];

            Point topLeftPoint = new Point(topLeftPointX, topLeftPointY);
            Point bottomRightPoint = new Point(rectangleCoordinates[2], rectangleCoordinates[3]);

            Rectangle rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            int pointsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointsCount; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                Point currentPoint = new Point(pointCoordinates[0], pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }
}
