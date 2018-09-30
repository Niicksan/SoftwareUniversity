using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> values = new Dictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                double currentNmber = nums[i];

                if (!values.ContainsKey(currentNmber))
                {
                    values.Add(currentNmber, 0);
                }

                values[currentNmber]++;
            }

            foreach (var number in values)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
