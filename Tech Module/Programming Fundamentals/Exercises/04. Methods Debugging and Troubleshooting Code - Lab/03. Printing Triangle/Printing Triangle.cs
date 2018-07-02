using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FirstPArt(n);
            SecondPart(n);
        }

        private static void FirstPArt(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Column(i);
            }
        }

        private static void SecondPart(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                Column(i);
            }
        }

        private static void Column(int i)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
        }
    }
}
