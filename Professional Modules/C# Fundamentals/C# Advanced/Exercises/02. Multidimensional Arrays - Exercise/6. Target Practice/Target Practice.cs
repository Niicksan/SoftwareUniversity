using System;
using System.Linq;

namespace _6._Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[size[0], size[1]];

            int impactRow = parameters[0];
            int impactColumn = parameters[1];
            int radius = parameters[2];

            FillingMatrix(word, matrix);

            Shouting(matrix, impactRow, impactColumn, radius);

            StartFolling(size, matrix);

            PrintMatrix(matrix);
        }      

        private static void FillingMatrix(string word, char[,] matrix)
        {
            bool left = true;
            bool right = false;

            int currentLetter = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (left)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = word[currentLetter];

                        if (currentLetter == word.Length - 1)
                        {
                            currentLetter = -1;
                        }

                        currentLetter++;

                    }

                    left = false;
                    right = true;

                    continue;
                }

                if (right)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        matrix[row, col] = word[currentLetter];

                        if (currentLetter == word.Length - 1)
                        {
                            currentLetter = -1;
                        }

                        currentLetter++;

                    }

                    left = true;
                    right = false;

                    continue;
                }
            }
        }

        private static void Shouting(char[,] matrix, int impactRow, int impactColumn, int radius)
        {
            matrix[impactRow, impactColumn] = ' ';
            //Calculate radius
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    double target = Math.Pow((row - impactRow), 2) + Math.Pow((col - impactColumn), 2);

                    if (target <= Math.Pow(radius, 2))
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static void StartFolling(int[] size, char[,] matrix)
        {
            int counter = size[0];

            while (counter >= 0)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row + 1, col] == ' ')
                        {
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = ' ';
                        }
                    }
                }

                counter--;
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }  
    }
}