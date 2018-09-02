using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {   // Works 100/100
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombNumbers[0];
            int power = bombNumbers[1];

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int leftIndex = i - power;
                int rightIndex = i + 1;
                int leftPower = power;
                int rightPower = power;

                if (numbers[i] == bomb)
                {
                    if (leftIndex <= 0)
                    {
                        leftIndex = 0;
                    }

                    if (i == numbers.Count)
                    {
                        leftIndex = 0;
                        rightIndex = 0;
                        leftPower = 0;
                        rightIndex = 0;
                    }

                    if (i - power <= 0)
                    {
                        leftPower = i;
                    }

                    if (i + power >= numbers.Count)
                    {
                        rightPower = numbers.Count - 1 - i;
                    }

                    if (rightIndex >= numbers.Count)
                    {
                        rightIndex = numbers.Count - 1 - i;
                    }

                    numbers.RemoveRange(rightIndex, rightPower);
                    numbers.RemoveRange(leftIndex, leftPower);
                    numbers.Remove(bomb);

                    i = 0;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
} 