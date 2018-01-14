using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            double lenght = 1.20;
            double width = 0.70;

            double numL = Math.Floor(l / lenght);
            double numW = Math.Floor((w - 1) / width);
            double sum = (numL * numW) - 3;

            Console.WriteLine(sum);
        }
    }
}
