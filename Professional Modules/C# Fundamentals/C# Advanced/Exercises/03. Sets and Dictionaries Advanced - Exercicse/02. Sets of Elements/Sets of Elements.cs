using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            HashSet<int> repeating = new HashSet<int>();

            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = sizes[0];
            int m = sizes[1];

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                first.Add(number);
            }

            for (int i = 1; i <= m; i++)
            {
                int number = int.Parse(Console.ReadLine());

                second.Add(number);
            }

            foreach (var number in first)
            {
                if (first.Contains(number) && second.Contains(number))
                {
                    repeating.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", repeating));
        }
    }
}
