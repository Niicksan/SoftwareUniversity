using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointIn_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            // Check the SPECIAL CASE, in which the both rectangle have common side 
            if ((x > h && x < 2 * h) && y == h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                //Divide the figure in two rectangles, made by 3 squares with side = h

                //Rectangle 1 -> the one on the bottom
                string position1 = "";
                if ((x > 0 && x < 3 * h) && (y > 0 && y < h))
                {
                    position1 = "inside";
                }
                else if (((x == 0 || x == 3 * h) && (y >= 0 && y <= h)) || ((y == 0 || y == h) && (x >= 0 && x <= 3 * h)))
                {
                    position1 = "border";
                }
                else
                {
                    position1 = "outside";
                }

                //Rectangle 2 -> the one on the top
                string position2 = "";
                if ((x > h && x < 2 * h) && (y > h && y < 4 * h))
                {
                    position2 = "inside";
                }
                else if (((x == 2 * h || x == h) && (y >= h && y <= 4 * h)) || ((y == 4 * h) && (x >= h && x <= 2 * h)))
                {
                    position2 = "border";
                }
                else
                {
                    position2 = "outside";
                }

                if (position1 == position2)
                {
                    Console.WriteLine(position1);
                }
                else
                {
                    if (position1 == "inside" || position2 == "inside")
                    {
                        Console.WriteLine("inside");
                    }
                    else if (position1 == "border" || position2 == "border")
                    {
                        Console.WriteLine("border");
                    }
                    else
                    {
                        Console.WriteLine("outside");

                    }
                }
            }       
        }
    }
}
