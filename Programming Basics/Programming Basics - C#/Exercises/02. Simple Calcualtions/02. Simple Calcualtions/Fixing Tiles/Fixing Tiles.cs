using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //n is the length of the side of the ground
            double n = double.Parse(Console.ReadLine());
            //w -> width of 1 tile          and    l -> length of 1 tile
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            // m -> width of the bench     and     o -> length of the bench 
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double groundArea = n * n;
            double benchArea = m * o;
            double tileArea = w * l;

            double tilesNeeded = (groundArea - benchArea) / tileArea;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
