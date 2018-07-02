using System;

namespace _08._Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(CenterPoint(x1, y1, x2, y2));
        }

        static string CenterPoint(double x1, double y1, double x2, double y2)
        {
            double resultX = Math.Abs(x1) + Math.Abs(y1);
            double resultY = Math.Abs(x1) + Math.Abs(y2);

            string result = "";

            if (resultX <= resultY)
            {
                result = $"({x1}, {y1})";
            }
            else
            {
                result = $"({x2}, {y2})";
            }

            return result;
        }
    }
}
