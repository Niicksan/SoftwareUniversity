using System;

namespace _02._Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);

        }

        static void PrintSign(int n)
        {
            string sign = "";

            if (n > 0)
            {
                sign = "positive";
            }
            else if (n < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {n} is {sign}.");
        }
    }
}
