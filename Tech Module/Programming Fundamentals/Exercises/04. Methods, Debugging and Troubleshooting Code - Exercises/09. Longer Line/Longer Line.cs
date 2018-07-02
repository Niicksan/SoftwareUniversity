using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());

            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());

            string coordinates = PrintLongerLine(firstX1, firstY1, firstX2, firstY2, secondX1, secondY1, secondX2, secondY2);
            Console.WriteLine(coordinates);
        }

        private static string PrintLongerLine(double firstX1, double firstY1, double firstX2, double firstY2, double secondX1, double secondY1, double secondX2, double secondY2)
        {
            double firstLineLenght = Math.Sqrt(Math.Pow((firstX2 - firstX1), 2) + Math.Pow((firstY2 - firstY1), 2));
            double secondlineLenght = Math.Sqrt(Math.Pow((secondX2 - secondX1), 2) + Math.Pow((secondY2 - secondY1), 2));

            string coordinates = "";

            if (firstLineLenght >= secondlineLenght)
            {
                bool isFirstCloser = closerPoint(firstX1, firstY1, firstX2, firstY2);

                if (isFirstCloser)
                {
                    coordinates = $"({firstX1}, {firstY1})({secondX2}, {firstY2})";
                }
                else
                {
                    coordinates = $"({firstX2}, {firstY2}({firstX1}, {firstY1})";
                }
            }
            else
            {
                bool isFirstCloser = closerPoint(secondX1, secondY1, secondX2, secondY2);

                if (isFirstCloser)
                {
                    coordinates = $"({secondX1}, {secondY1})({secondX2}, {secondY2})";
                }
                else
                {
                    coordinates = $"({secondX2}, {secondY2})({secondX1}, {secondY1})";
                }
            }

            return coordinates;
        }

        private static bool closerPoint(double firstX1, double firstY1, double firstX2, double firstY2)
        {
            double firstPointLine = Math.Sqrt((firstX1 * firstX1) + (firstY1 * firstY1));
            double secondPointLine = Math.Sqrt((firstX2 * firstX2) + (firstY2 * firstY2));

            bool isFirstCloser = true;

            if (firstPointLine <= secondPointLine)
            {
                isFirstCloser = true;
            }
            else
            {
                isFirstCloser = false;
            }

            return isFirstCloser;
        }
    }
}
