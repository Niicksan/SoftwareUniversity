using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();

            List<int> numbers = nums.Split().Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != 0 && i != numbers.Count - 1)
                {
                    if (numbers[i] == (numbers[i - 1] + numbers[i + 1]))
                    {
                        numbers.RemoveAt(i + 1);
                        numbers.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else if (i == 0 && numbers[i] == numbers[i + 1])
                {
                    numbers.RemoveAt(i + 1);
                    i = 0;
                }
                else if (i == numbers.Count - 1 && numbers[i] == numbers[i - 1])
                {
                    numbers.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}