using System;

namespace _09._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digit = i;
                int sum = 0;

                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
