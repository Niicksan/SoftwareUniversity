﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 1)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('*', n - 2));
                }

                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('-', n - 2));
                }
            }

            Console.Write(new string(' ', n - 1));
            Console.WriteLine("@");

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 1)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('*', n - 2));
                }

                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('-', n - 2));
                }
            }
        }
    }
}
