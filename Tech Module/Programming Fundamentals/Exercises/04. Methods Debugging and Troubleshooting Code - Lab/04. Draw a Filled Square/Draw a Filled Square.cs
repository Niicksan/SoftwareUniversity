using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintDashes(n);
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("-{0}-", NewString("\\/", n - 1));
            }
            PrintDashes(n);
        }

        private static void PrintDashes(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        private static string NewString(string symbol, int n)
        {
            string sign = "";
            for (int i = 1; i <= n; i++)
            {
                sign += symbol;
            }

            return sign;
        }
    }
}
