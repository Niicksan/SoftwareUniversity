using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Cup
{
    class Cup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDots = n;
            int center = (5 * n) - (2 * n + 2);

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('.', firstDots));
                Console.Write("#");
                Console.Write(new string('#', center));
                Console.Write("#");
                Console.WriteLine(new string('.', firstDots));
                firstDots++;
                center -= 2;
            }

            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.Write(new string('.', firstDots));
                Console.Write("#");
                Console.Write(new string('.', center));
                Console.Write("#");
                Console.WriteLine(new string('.', firstDots));
                firstDots++;
                center -= 2;
            }

            firstDots--;
            center += 2;
            Console.Write(new string('.', firstDots));
            Console.Write("#");
            Console.Write(new string('#', center));
            Console.Write("#");
            Console.WriteLine(new string('.', firstDots));

            firstDots -= 2;
            center += 4;

            for (int row = 1; row <= n + 2; row++)
            {
                if (row == (n + 2) / 2)
                {
                    Console.Write(new string('.', (5 * n - 10) / 2));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', (5 * n - 10) / 2));
                }

                else
                {
                    Console.Write(new string('.', firstDots));
                    Console.Write("#");
                    Console.Write(new string('#', center));
                    Console.Write("#");
                    Console.WriteLine(new string('.', firstDots));
                }
            }
        }
    }
}
