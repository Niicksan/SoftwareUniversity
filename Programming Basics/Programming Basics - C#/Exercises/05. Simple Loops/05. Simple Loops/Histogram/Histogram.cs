using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            nt n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            int contP1 = 0;
            int contP2 = 0;
            int contP3 = 0;
            int contP4 = 0;
            int contP5 = 0;

            for (int num = 1; num <= n; num++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    contP1++;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    contP2++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    contP3++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    contP4++;
                }
                else
                {
                    contP5++;
                }
            }

            p1 = (contP1 * 100.00) / n;
            p2 = (contP2 * 100.00) / n;
            p3 = (contP3 * 100.00) / n;
            p4 = (contP4 * 100.00) / n;
            p5 = (contP5 * 100.00) / n;
            Console.WriteLine(string.Format("{0:f2}%", p1));
            Console.WriteLine(string.Format("{0:f2}%", p2));
            Console.WriteLine(string.Format("{0:f2}%", p3));
            Console.WriteLine(string.Format("{0:f2}%", p4));
            Console.WriteLine(string.Format("{0:f2}%", p5));
        }
    }
}
