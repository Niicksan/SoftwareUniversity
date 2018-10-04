using System;
using System.Linq;

namespace _5._Rubiks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[][] rubicMatrix = new int[rows][];

            GetMatrix(rubicMatrix, cols);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                int rowCollIndex = int.Parse(input[0]);
                string direction = input[1];
                int moves = int.Parse(input[2]);

                if (direction == "down")
                {
                    MoveDown(rubicMatrix, rowCollIndex, moves % rubicMatrix.Length);
                }
                else if (direction == "left")
                {
                    MoveLeft(rubicMatrix, rowCollIndex, moves % rubicMatrix[0].Length);
                }
                else if (direction == "right")
                {
                    MoveRight(rubicMatrix, rowCollIndex, moves % rubicMatrix[0].Length);
                }
                else if (direction == "up")
                {
                    MoveUp(rubicMatrix, rowCollIndex, moves % rubicMatrix.Length);
                }     
            }

            int counter = 1;

            for (int row = 0; row < rubicMatrix.Length; row++)
            {
                for (int col = 0; col < rubicMatrix[row].Length; col++)
                {
                    if (rubicMatrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearrange(rubicMatrix, row, col, counter);
                        counter++;
                    }
                }
            }
        }

        private static void Rearrange(int[][] rubicMatrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < rubicMatrix.Length; targetRow++)
            {
                for (int targetCol = 0; targetCol < rubicMatrix[targetRow].Length; targetCol++)
                {
                    if (rubicMatrix[targetRow][targetCol] == counter)
                    {
                        rubicMatrix[targetRow][targetCol] = rubicMatrix[row][col];
                        rubicMatrix[row][col] = counter;

                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");

                        return;
                    }
                }
            }
        }

        private static void MoveUp(int[][] rubicMatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = rubicMatrix[0][col];

                for (int row = 0; row < rubicMatrix.Length - 1; row++)
                {
                    rubicMatrix[row][col] = rubicMatrix[row + 1][col];
                }

                rubicMatrix[rubicMatrix.Length - 1][col] = firstElement;
            }
        }

        private static void MoveRight(int[][] rubicMatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = rubicMatrix[row][rubicMatrix[row].Length - 1];

                for (int col = rubicMatrix.Length - 1; col > 0; col--)
                {
                    rubicMatrix[row][col] = rubicMatrix[row][col - 1];
                }

                rubicMatrix[row][0] = lastElement;
            }
        }

        private static void MoveLeft(int[][] rubicMatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = rubicMatrix[row][0];

                for (int col = 0; col < rubicMatrix[row].Length - 1; col++)
                {
                    rubicMatrix[row][col] = rubicMatrix[row][col + 1];
                }

                rubicMatrix[row][rubicMatrix[row].Length - 1] = firstElement;
            }
        }

        private static void MoveDown(int[][] rubicMatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = rubicMatrix[rubicMatrix.Length - 1][col];

                for (int row = rubicMatrix.Length - 1; row > 0; row--)
                {
                    rubicMatrix[row][col] = rubicMatrix[row - 1][col];
                }

                rubicMatrix[0][col] = lastElement;
            }
        }

        private static void Print(int[][] rubicMatrix)
        {
            for (int row = 0; row < rubicMatrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", rubicMatrix[row]));
            }
        }

        private static void GetMatrix(int[][] rubicMatrix, int cols)
        {
            int counter = 1;

            for (int row = 0; row < rubicMatrix.Length; row++)
            {
                rubicMatrix[row] = new int[cols];

                for (int col = 0; col < rubicMatrix[row].Length; col++)
                {
                    rubicMatrix[row][col] = counter++;
                }
            }
        }
    }
}