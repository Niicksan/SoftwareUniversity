using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            double cake = width * length;
            double cntPieces = cake;

            while (cntPieces >= 0)
            {
                {
                    try
                    {
                        int pieces = int.Parse(Console.ReadLine());
                        cntPieces -= pieces;
                    }

                    catch
                    {
                        break;
                    }
                }
            }

            if (cntPieces >= 0)
            {
                Console.WriteLine("{0} pieces are left.", cntPieces);
            }

            else
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(cntPieces));
            }
        }
    }
}
