using System;
using System.Linq;

namespace _03._Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = int.Parse(Console.ReadLine());

            int[] numbers = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
