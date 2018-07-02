using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Easter_Egg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDots = 2 * n;
            int stars = n;
            int midStars = 1;
            int pluses = n + 2;

            Console.WriteLine("{0}{1}{0}", new string('.', firstDots), new string('*', stars));
            firstDots -= 2;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',firstDots), new string('*', midStars), new string('+', pluses));
                firstDots -= 2;
                midStars++;
                pluses += 2;
            }

            firstDots++;
            midStars -= 2;
            int equal = (5 * n) - (2 * firstDots) - 4;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', firstDots), new string('*', 2), new string('=', equal));
                firstDots --;
                equal += 2;
            }
            equal -= 2;
            firstDots++;
            int sign = ((5 * n) - (2 * firstDots) - 16) / 2;
            Console.WriteLine("{0}{1}{2}HAPPY EASTER{2}{1}{0}", new string('.', firstDots), new string('*', 2), new string('~', sign));

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', firstDots), new string('*', 2), new string('=', equal));
                firstDots++;
                equal -= 2;
            }

            midStars++;
            pluses = (5 * n) - (2 * firstDots) - (2 * midStars);
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', firstDots), new string('*', midStars), new string('+', pluses));
                firstDots += 2;
                midStars--;
                pluses -= 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', firstDots), new string('*', stars));
        }
    }
}