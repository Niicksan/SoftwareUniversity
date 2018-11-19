﻿using System;

namespace _1._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int starCount = 1; starCount <= size; starCount++)
            {
                PrintStars(size, starCount);
            }

            for (int starCount = size - 1; starCount >= 1; starCount--)
            {
                PrintStars(size, starCount);
            }
        }

        private static void PrintStars(int size, int starCount)
        {
            for (int i = 0; i < size - starCount; i++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col < starCount; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}