using System;
using System.Linq;

namespace _2._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        firstDiagonal += matrix[row, col];
                    }

                    if (col == n - row - 1)
                    {
                        secondDiagonal += matrix[row, col];
                    }
                }
            }           

            int diff = Math.Abs(firstDiagonal - secondDiagonal);

            Console.WriteLine(diff);
        }
    }
}
