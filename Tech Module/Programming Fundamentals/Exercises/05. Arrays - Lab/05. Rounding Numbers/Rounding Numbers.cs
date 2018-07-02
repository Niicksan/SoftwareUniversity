using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersAsString = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNumbers = new int[numbersAsString.Length];

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbersAsString[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                Console.WriteLine($"{numbersAsString[i]} -> {roundedNumbers[i]}");
            }
        }
    }
}
