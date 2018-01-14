using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lengthtable = double.Parse(Console.ReadLine());
            double widthtable = double.Parse(Console.ReadLine());

            double lenghtSquare = lengthtable / 2;

            double areaTables = tables * (lengthtable + 2 * 0.30) * (widthtable + 2 * 0.30);
            double areaSquare = tables * lenghtSquare * lenghtSquare;

            double priceDollars = areaTables * 7 + areaSquare * 9;
            double priceLeva = priceDollars * 1.85;

            Console.WriteLine("{0:f2} USD", priceDollars);
            Console.WriteLine("{0:f2} BGN", priceLeva);
        }
    }
}
