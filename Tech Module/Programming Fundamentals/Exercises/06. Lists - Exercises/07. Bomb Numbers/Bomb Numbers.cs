using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {   // Work but 60/100
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            BombTheNumbers(numbers, bombNumbers);

            int sum = SumNumbers(numbers);

            Console.WriteLine(sum);
        }

        static int SumNumbers(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void BombTheNumbers(List<int> numbers, List<int> bombNumbers)
        {

            int bomb = bombNumbers[0];
            int power = bombNumbers[1];

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int leftIndex = i - power;
                int rightIndex = i + 1;
                int leftPower = power + 1;

                if (numbers[i] == bomb)
                {
                    if (i == numbers.Count)
                    {
                        power = 0;
                    }

                    if (i + power >= numbers.Count)
                    {
                        power = numbers.Count - i - 1;
                    }

                    numbers.RemoveRange(rightIndex, power);

                    if (leftIndex < 0)
                    {
                        leftIndex = 0;
                    }

                    numbers.RemoveRange(leftIndex, leftPower);
                }
            }
        }
    }
} 