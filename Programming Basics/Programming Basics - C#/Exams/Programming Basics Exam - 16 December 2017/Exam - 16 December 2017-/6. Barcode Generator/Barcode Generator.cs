﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            int dig1 = start / 1000;
            int dig2 = (start % 1000) / 100;
            int dig3 = (start % 100) / 10;
            int dig4 = (start % 10);

            int d1 = stop / 1000;
            int d2 = (stop % 1000) / 100;
            int d3 = (stop % 100) / 10;
            int d4 = (stop % 10);

            for (int row1 = dig1; row1 <= d1; row1++)
            {
                for (int row2 = dig2; row2 <= d2; row2++)
                {
                    for (int row3 = dig3; row3 <= d3; row3++)
                    {
                        for (int row4 = dig4; row4 <= d4; row4++)
                        {
                            if (row1 % 2 == 1 && row2 % 2 == 1 &&
                                row3 % 2 == 1 && row4 % 2 == 1)
                            {
                                Console.Write("{0}{1}{2}{3} ", row1, row2, row3, row4);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
