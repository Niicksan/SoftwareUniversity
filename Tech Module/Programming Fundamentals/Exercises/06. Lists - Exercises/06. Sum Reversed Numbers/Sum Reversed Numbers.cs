using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            sum = ReverseNumberInList(numbers, sum);

            Console.WriteLine(sum);
        }

        static int ReverseNumberInList(List<int> numbers, int sum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int reversed = 0;
                while (numbers[i] > 0)
                {
                    int remainder = numbers[i] % 10;
                    reversed = (reversed * 10) + remainder;
                    numbers[i] /= 10;
                }
                sum += reversed;
            }

            return sum;
        }
    }
}
