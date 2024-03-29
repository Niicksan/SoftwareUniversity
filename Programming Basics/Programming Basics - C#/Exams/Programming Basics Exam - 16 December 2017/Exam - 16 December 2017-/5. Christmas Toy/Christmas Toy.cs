﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDashes = 2 * n;
            int firstStars = n;
            int and = n + 2;
            int stars = 1;

            Console.Write(new string('-', firstDashes));
            Console.Write(new string('*', firstStars));
            Console.WriteLine(new string('-', firstDashes));
            firstDashes -= 2;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write(new string('*', stars));
                Console.Write(new string('&', and));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', firstDashes));
                firstDashes -= 2;
                stars++;
                and += 2;
            }

            firstDashes++;
            int symbol = 5 * n - (2 * firstDashes + 4);
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write("*");
                Console.Write("*");
                Console.Write(new string('~', symbol));
                Console.Write("*");
                Console.Write("*");
                Console.WriteLine(new string('-', firstDashes));
                firstDashes--;
                symbol += 2;
            }

            firstDashes++;
            symbol -= 2;
            int newSymbol = 5 * n - (2 * firstDashes + 2);

            Console.Write(new string('-', firstDashes));
            Console.Write("*");
            Console.Write(new string('|', newSymbol));
            Console.Write("*");
            Console.WriteLine(new string('-', firstDashes));

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write("*");
                Console.Write("*");
                Console.Write(new string('~', symbol));
                Console.Write("*");
                Console.Write("*");
                Console.WriteLine(new string('-', firstDashes));
                firstDashes++;
                symbol -= 2;
            }

            stars--;
            and -= 2;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write(new string('*', stars));
                Console.Write(new string('&', and));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', firstDashes));
                firstDashes += 2;
                stars--;
                and -= 2;
            }

            Console.Write(new string('-', firstDashes));
            Console.Write(new string('*', firstStars));
            Console.WriteLine(new string('-', firstDashes));
        }
    }
}
