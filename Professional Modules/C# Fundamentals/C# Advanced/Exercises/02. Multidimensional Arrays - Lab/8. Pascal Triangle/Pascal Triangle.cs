using System;

namespace _8._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            long[][] jagged = new long[n][];
            jagged[0] = new long[2];

            jagged[0][0] = 1;
            jagged[0][1] = 0;

            for (int row = 1; row < jagged.Length; row++)
            {
                jagged[row] = new long[row + 2];

                for (int col = 1; col < row + 1; col++)
                {                                      
                    jagged[row][0] = 1;
                    jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length - 1; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
