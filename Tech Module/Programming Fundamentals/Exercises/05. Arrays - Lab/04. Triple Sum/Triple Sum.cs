using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        private static object parse;

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool foundSum = TrupleSum(numbers);

            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }

        private static bool TrupleSum(int[] numbers)
        {
            bool fond = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    int sum = numbers[i] + numbers[k];

                    if (numbers.Contains(sum))
                    {
                        fond = true;
                        Console.WriteLine($"{numbers[i]} + {numbers[k]} == {sum}");
                    }
                }
            }

            return fond;
        }
    }
}
