﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firtRowIntervals = n + 1;
            int intervals = n;
            int dashes = (2 * n) - 1;
            int stop = (((4 * n) + 3) - 9) / 2;

            Console.Write(new string('.', firtRowIntervals));
            Console.Write(new string('_', (2 * n) + 1));
            Console.WriteLine(new string('.', firtRowIntervals));

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', intervals));
                Console.Write("//");
                Console.Write(new string('_', dashes));
                Console.Write(@"\\");
                Console.WriteLine(new string('.', intervals));

                intervals--;
                dashes += 2;
            }

            //4 * n + 3
            Console.Write("//");
            Console.Write(new string('_', stop));
            Console.Write("STOP!");
            Console.Write(new string('_', stop));
            Console.WriteLine(@"\\");


            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', intervals));
                Console.Write(@"\\");
                Console.Write(new string('_', dashes));
                Console.Write("//");
                Console.WriteLine(new string('.', intervals));

                intervals++;
                dashes -= 2;
            }
        }
    }
}
