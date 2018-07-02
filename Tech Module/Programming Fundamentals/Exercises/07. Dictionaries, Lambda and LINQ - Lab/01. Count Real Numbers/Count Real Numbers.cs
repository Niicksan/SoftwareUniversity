using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> countNUmbers = new SortedDictionary<double, int>();
            double[] numbers = Console.ReadLine().
                Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!countNUmbers.ContainsKey(numbers[i]))
                {
                    countNUmbers.Add(numbers[i], 1);
                }
                else
                {
                    countNUmbers[numbers[i]]++;
                }
            }

            foreach (var number in countNUmbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
