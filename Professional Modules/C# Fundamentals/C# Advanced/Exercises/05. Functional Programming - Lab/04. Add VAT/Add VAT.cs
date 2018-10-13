using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(n => n * 1.20).ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
