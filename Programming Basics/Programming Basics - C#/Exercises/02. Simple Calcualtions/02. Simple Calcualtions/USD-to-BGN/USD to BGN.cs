﻿using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = 1.79549 * USD;

            Console.WriteLine(Math.Round(BGN, 2) + " BGN");
        }
    }
}