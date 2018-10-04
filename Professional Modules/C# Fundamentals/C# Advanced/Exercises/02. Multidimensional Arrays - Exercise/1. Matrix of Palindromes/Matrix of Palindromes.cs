using System;
using System.Linq;

namespace _1._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = alphabet[row + col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{alphabet[row]}{matrix[row, col]}{alphabet[row]} ");
                }

                Console.WriteLine();
            }
        }
    }
}