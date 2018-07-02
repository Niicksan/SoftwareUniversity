using System;

namespace _07.__Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string primeNumbers = PrintPrime(start, end);
            Console.WriteLine(primeNumbers);
        }

        private static string PrintPrime(int start, int end)
        {
            string primeNumbers = "";

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                if (i < 2)
                {
                    isPrime = false;
                }

                int count = 2;

                while (count <= Math.Sqrt(i))
                {
                    if (i % count == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    count++;
                }

                if (isPrime)
                {
                    primeNumbers += $"{i}, ";
                }
            }

            primeNumbers = primeNumbers.Remove(primeNumbers.Length - 2);

            return primeNumbers;
        }
    }
}
