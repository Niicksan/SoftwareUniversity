using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = FindFactorial(n);
            factorial = NewMethod(factorial);

        }

        private static BigInteger NewMethod(BigInteger factorial)
        {
            string factorialString = Convert.ToString(factorial);
            int count = 0;

            for (BigInteger i = 1; i <= factorialString.Length; i++)
            {
                if (factorial % 10 == 0)
                {
                    count++;
                    factorial /= 10;
                }
            }

            Console.WriteLine(count);
            return factorial;
        }

        private static BigInteger FindFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
