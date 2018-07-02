using System;
using System.Numerics;

namespace _13._Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = PrintFactorial(n);

            Console.WriteLine(factorial);
        }

        private static BigInteger PrintFactorial(int n)
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
