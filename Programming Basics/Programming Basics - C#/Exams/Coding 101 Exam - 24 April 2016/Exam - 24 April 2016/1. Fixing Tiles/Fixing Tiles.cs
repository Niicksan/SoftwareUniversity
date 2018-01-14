using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fixing_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double blockW = double.Parse(Console.ReadLine());
            double blockL = double.Parse(Console.ReadLine());
            double benchW = double.Parse(Console.ReadLine());
            double benchL = double.Parse(Console.ReadLine());

            double nArea = n * n;
            double blockArea = blockW * blockL;
            double benchArea = benchW * benchL;

            double num = (nArea - benchArea) / blockArea;
            double speed = (num * 0.2);

            Console.WriteLine(string.Format("{0:F2}", num));
            Console.WriteLine(string.Format("{0:F2}", speed));
        }
    }
}
