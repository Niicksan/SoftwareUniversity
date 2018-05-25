using System;

namespace _11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            while (n % 2 != 1)
            {
                Console.WriteLine("Please write an odd number.");
                n = Math.Abs(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"The number is: {n}");
        }
    }
}
