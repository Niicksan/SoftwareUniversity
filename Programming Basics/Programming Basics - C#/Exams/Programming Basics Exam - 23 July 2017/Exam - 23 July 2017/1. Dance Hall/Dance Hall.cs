using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobe = double.Parse(Console.ReadLine());

            double areaHall = (lenght * 100) * (width * 100);
            double areaBench = areaHall / 10;
            double areaWardrobe = (wardrobe * 100) * (wardrobe * 100);

            double leftSpace = areaHall - areaBench - areaWardrobe;
            double dancers = leftSpace / (40 + 7000);

            Console.WriteLine("{0}", Math.Floor(dancers));
        }
    }
}
