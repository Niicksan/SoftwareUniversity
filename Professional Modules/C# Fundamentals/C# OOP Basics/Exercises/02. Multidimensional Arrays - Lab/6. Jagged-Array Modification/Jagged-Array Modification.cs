using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jagged[row] = new int[elements.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = elements[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split().ToArray();

                string opr = tokens[0];
                int rrow = int.Parse(tokens[1]);
                int column = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (opr == "Add")
                {
                    bool isFond = false;

                    for (int row = 0; row < jagged.Length; row++)
                    {
                        for (int col = 0; col < jagged[row].Length; col++)
                        {
                            if (row == rrow && col == column)
                            {
                                isFond = true;

                                jagged[row][col] += value;
                            }
                        }
                    }

                    if (!isFond)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (opr == "Subtract")
                {
                    bool isFond = false;

                    for (int row = 0; row < jagged.Length; row++)
                    {
                        for (int col = 0; col < jagged[row].Length; col++)
                        {
                            if (row == rrow && col == column)
                            {
                                isFond = true;

                                jagged[row][col] -= value;
                            }
                        }
                    }

                    if (!isFond)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
