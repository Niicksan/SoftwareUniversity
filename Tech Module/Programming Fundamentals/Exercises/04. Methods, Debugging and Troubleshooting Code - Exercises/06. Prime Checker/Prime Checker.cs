using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine(IsPrime(n));
            }
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;
            int count = 2;

            while (count <= Math.Sqrt(n))
            {
                if (n % count == 0)
                {
                    isPrime = false;
                    break;
                }
                count++;
            }

            return isPrime;
        }
    }
}
