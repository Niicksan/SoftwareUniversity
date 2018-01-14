using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDots = 0;
            int centralDots = n;

            for (int first = 1; first <= n - 1; first++)
            {
                Console.Write(new string('.', firstDots));
                Console.Write("*");
                Console.Write(new string('.', centralDots));
                Console.Write("*");
                Console.Write(new string('.', centralDots));
                Console.Write("*");
                Console.WriteLine(new string('.', firstDots));
                firstDots++;
                centralDots--;
            }

            Console.Write(new string('.', firstDots));
            Console.Write("*");
            Console.Write(new string('*', centralDots));
            Console.Write("*");
            Console.Write(new string('*', centralDots));
            Console.Write("*");
            Console.WriteLine(new string('.', firstDots));

            Console.WriteLine(new string('*', 2 * n + 3));

            for (int second = 1; second <= n - 1; second++)
            {
                if (second == 1)
                {
                    Console.Write(new string('.', firstDots));
                    Console.Write("*");
                    Console.Write(new string('*', centralDots));
                    Console.Write("*");
                    Console.Write(new string('*', centralDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', firstDots));
                    firstDots--;
                    centralDots++;
                }

                Console.Write(new string('.', firstDots));
                Console.Write("*");
                Console.Write(new string('.', centralDots));
                Console.Write("*");
                Console.Write(new string('.', centralDots));
                Console.Write("*");
                Console.WriteLine(new string('.', firstDots));
                firstDots--;
                centralDots++;
            }
        }
    }
}
