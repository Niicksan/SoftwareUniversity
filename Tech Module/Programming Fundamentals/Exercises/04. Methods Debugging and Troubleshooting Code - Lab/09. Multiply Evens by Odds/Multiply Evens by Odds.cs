using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetEvenOddSum(number);
            Console.WriteLine(result);
        }

        private static int GetEvenOddSum(int number)
        {
            int evenSum = 0;
            int oddSum = 0;

            while (number > 0)
            {
                int lasdtDigit = number % 10;

                if (lasdtDigit % 2 == 0)
                {
                    evenSum += lasdtDigit;
                }
                else
                {
                    oddSum += lasdtDigit;
                }

                number /= 10;
            }

            return evenSum * oddSum;
        }
    }
}
