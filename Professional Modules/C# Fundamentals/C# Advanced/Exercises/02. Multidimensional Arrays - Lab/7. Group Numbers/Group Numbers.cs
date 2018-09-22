using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] jagged = new int[3][];

            List<int> zero = new List<int>();
            List<int> one = new List<int>();
            List<int> two = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Abs(input[i]) % 3 == 0)
                {
                    zero.Add(input[i]);
                }
                else if (Math.Abs(input[i]) % 3 == 1)
                {
                    one.Add(input[i]);
                }
                else if (Math.Abs(input[i]) % 3 == 2)
                {
                    two.Add(input[i]);
                }
            }

            jagged[0] = zero.ToArray();
            jagged[1] = one.ToArray();
            jagged[2] = two.ToArray();

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
