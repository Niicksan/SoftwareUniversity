using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sheriff
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            // Exam - 17 September 2017
            int n = int.Parse(Console.ReadLine());

            int dotsFirst = ((3 * n) - 1) / 2;
            int dotsLast = ((3 * n) - 3) / 2;

            Console.Write(new string('.', dotsFirst));
            Console.Write("x");
            Console.WriteLine(new string('.', dotsFirst));

            Console.Write(new string('.', dotsLast));
            Console.Write("/");
            Console.Write("x");
            Console.Write(@"\");
            Console.WriteLine(new string('.', dotsLast));

            Console.Write(new string('.', dotsLast));
            Console.Write("x");
            Console.Write("|");
            Console.Write("x");
            Console.WriteLine(new string('.', dotsLast));

            int Xes = n;
            int dots = ((3 * n) - ((2 * n) + 1)) / 2;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('x', Xes));
                Console.Write("|");
                Console.Write(new string('x', Xes));
                Console.WriteLine(new string('.', dots));
                dots--;
                Xes++;
                if (dots == -1)
                {
                    break;
                }
            }

            dots += 2;
            Xes -= 2;
            for (int i = 1; i <= (n / 2); i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('x', Xes));
                Console.Write("|");
                Console.Write(new string('x', Xes));
                Console.WriteLine(new string('.', dots));
                dots++;
                Xes--;
            }

            Console.Write(new string('.', dotsLast));
            Console.Write("/");
            Console.Write("x");
            Console.Write(@"\");
            Console.WriteLine(new string('.', dotsLast));

            Console.Write(new string('.', dotsLast));
            Console.Write(@"\");
            Console.Write("x");
            Console.Write("/");
            Console.WriteLine(new string('.', dotsLast));

            int xes = n;
            int Dots = ((3 * n) - ((2 * n) + 1)) / 2;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', Dots));
                Console.Write(new string('x', xes));
                Console.Write("|");
                Console.Write(new string('x', xes));
                Console.WriteLine(new string('.', Dots));
                Dots--;
                xes++;
                if (Dots == -1)
                {
                    break;
                }
            }

            Dots += 2;
            xes -= 2;
            for (int i = 1; i <= (n / 2); i++)
            {
                Console.Write(new string('.', Dots));
                Console.Write(new string('x', xes));
                Console.Write("|");
                Console.Write(new string('x', xes));
                Console.WriteLine(new string('.', Dots));
                Dots++;
                xes--;
            }

            Console.Write(new string('.', dotsLast));
            Console.Write("x");
            Console.Write("|");
            Console.Write("x");
            Console.WriteLine(new string('.', dotsLast));

            Console.Write(new string('.', dotsLast));
            Console.Write(@"\");
            Console.Write("x");
            Console.Write("/");
            Console.WriteLine(new string('.', dotsLast));

            Console.Write(new string('.', dotsFirst));
            Console.Write("x");
            Console.WriteLine(new string('.', dotsFirst));
        }
    }
}
