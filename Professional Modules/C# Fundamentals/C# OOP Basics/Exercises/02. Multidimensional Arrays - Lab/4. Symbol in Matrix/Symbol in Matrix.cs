using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int rowIndex = 0;
            int colIndex = 0;

            bool isFind = false;

            for (int row = 0; row < n; row++)
            {
                string ascii = Console.ReadLine().TrimEnd();

                char[] elements = new char[ascii.Length];

                for (int i = 0; i < ascii.Length; i++)
                {
                    elements[i] = ascii[i];
                }

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isFind = true;

                        rowIndex = row;
                        colIndex = col;

                        
                    }          
                }
            }

            if (isFind)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }


            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {

            //        Console.Write(matrix[row, col]);
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
