using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = n;
            int stars = (5 * n) - ((2 * n) + 2);

            for (int first = 1; first <= n; first++)
            {
                if (first == 1)
                {
                    Console.Write(new string('.', dots));
                    Console.Write("*");
                    Console.Write(new string('*', stars));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dots));
                    dots--;
                    stars += 2;
                }

                else
                {
                    Console.Write(new string('.', dots));
                    Console.Write("*");
                    Console.Write(new string('.', stars));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dots));
                    dots--;
                    stars += 2;
                }
            }
            Console.WriteLine(new string('*', 5 * n));

            int firstDots = 1;
            int centralDots = (5 * n) - 4;
            for (int second = 1; second <= 2 * n + 1; second++)
            {
                if (second < 2 * n + 1)
                {
                    Console.Write(new string('.', firstDots));
                    Console.Write("*");
                    Console.Write(new string('.', centralDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', firstDots));
                    firstDots++;
                    centralDots -= 2;
                }

                else
                {
                    Console.Write(new string('.', firstDots));
                    Console.Write("*");
                    Console.Write(new string('*', centralDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', firstDots));
                    firstDots++;
                    centralDots -= 2;
                }
            }
        }
    }
}
