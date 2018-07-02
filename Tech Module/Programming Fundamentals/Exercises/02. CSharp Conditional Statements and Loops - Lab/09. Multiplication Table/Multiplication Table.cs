using System;

namespace _09._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = 1;

            for (int i = 1; i <= 10; i++)
            {
                int result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
                multiplier++;
            }
        }
    }
}
