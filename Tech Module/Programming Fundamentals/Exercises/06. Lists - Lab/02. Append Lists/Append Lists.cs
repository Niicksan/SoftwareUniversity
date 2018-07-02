using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();

            var numbers = new List<List<int>>();
            for (int i = 0; i < input.Count; i++)
            {
                numbers.Add(new List<int>());
                numbers[i] = input[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.Write(string.Join(" ", numbers[i]) + " ");
            }

            Console.WriteLine();
        }
    }
}
