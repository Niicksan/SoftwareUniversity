using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(numbers[0]);
                }
                else if (numbers.Length % 2 == 1)
                {
                    for (int k = 0; k < numbers.Length / 2; k++)
                    {
                        Console.Write("{ " + $"{numbers[(numbers.Length / 2) - 1]}, {numbers[numbers.Length / 2]}, {numbers[(numbers.Length / 2) + 1]}" + " }");
                        break;
                    }
                }
                else if (numbers.Length % 2 == 0)
                {
                    for (int l = 0; l < numbers.Length / 2; l++)
                    {
                        Console.Write("{ " + $"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}" + " }");
                        break;
                    }
                }
                break;
            }
            Console.WriteLine();
        }
    }
}
