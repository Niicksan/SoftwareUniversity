using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condense = new int[numbers.Length - 1];
                int sum = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condense[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condense;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
