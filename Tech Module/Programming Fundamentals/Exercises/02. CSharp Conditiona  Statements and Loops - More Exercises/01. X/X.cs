using System;

namespace _01._X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstSpaces = 0;
            int middleSpaces = n - 2;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string(' ', firstSpaces) + "x" + new string(' ', middleSpaces) + "x");
                firstSpaces++;
                middleSpaces -= 2;
            }

            firstSpaces = n / 2;
            middleSpaces = 1;
            Console.WriteLine(new string(' ', firstSpaces) + "x");
            firstSpaces--;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', firstSpaces) + "x" + new string(' ', middleSpaces) + "x");
                firstSpaces--;
                middleSpaces += 2;
            }
        }
    }
}
