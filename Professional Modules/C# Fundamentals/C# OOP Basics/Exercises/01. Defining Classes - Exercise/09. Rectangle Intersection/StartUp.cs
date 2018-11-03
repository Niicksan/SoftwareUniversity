using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<Rectangle> rectangles = GetRectanfles(input);

            CheckRectanglesIntersections(rectangles, input);
        }

        private static void CheckRectanglesIntersections(List<Rectangle> rectangles, List<int> input)
        {
            int intersectionChecks = input[1];
            for (int i = 0; i < intersectionChecks; i++)
            {
                string[] args = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Rectangle firstRectangle = rectangles.FirstOrDefault(r => r.Id == args[0]);
                Rectangle secondRectangle = rectangles.FirstOrDefault(r => r.Id == args[1]);

                if (firstRectangle == null || secondRectangle == null)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine(firstRectangle.IntersectsRectangle(secondRectangle) ? "true" : "false");
                }
            }
        }

        private static List<Rectangle> GetRectanfles(List<int> input)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            int numberOfRectangles = input[0];

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] rectangleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string id = rectangleInfo[0];
                double width = double.Parse(rectangleInfo[1]);
                double height = double.Parse(rectangleInfo[2]);
                double coordinatesTopLeftX = double.Parse(rectangleInfo[3]);
                double coordinatesTopLeftY = double.Parse(rectangleInfo[4]);

                Rectangle rectangle = new Rectangle(id, width, height, coordinatesTopLeftX, coordinatesTopLeftY);

                rectangles.Add(rectangle);
            }

            return rectangles;
        }
    }
}