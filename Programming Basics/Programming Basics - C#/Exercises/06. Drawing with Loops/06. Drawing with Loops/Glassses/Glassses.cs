using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glassses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write(new string('*', 2 * n));
                    Console.Write(new string(' ', n));
                    Console.WriteLine(new string('*', 2 * n));
                }

                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    if (n % 2 == 0)
                    {
                        if (row == n / 2)
                        {
                            Console.Write(new string('|', n));
                        }
                        else
                        {
                            Console.Write(new string(' ', n));
                        }
                    }
                    else
                    {
                        if (row == (n / 2) + 1)
                        {
                            Console.Write(new string('|', n));
                        }
                        else
                        {
                            Console.Write(new string(' ', n));
                        }
                    }
                    
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.WriteLine("*");
                }
            }
        }
    }
}
