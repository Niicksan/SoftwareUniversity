using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(GetFibonacci(n));
            }
        }

        static int GetFibonacci(int n)
        {
            int firstPreviousNumber = 0;
            int secondPreviousNumber = 1;
            int fibonacci = 0;

            for (int i = 2; i <= n; i++)
            {
                fibonacci = firstPreviousNumber + secondPreviousNumber;
                firstPreviousNumber = secondPreviousNumber;
                secondPreviousNumber = fibonacci;
            }

            return fibonacci;
        }
    }
}
