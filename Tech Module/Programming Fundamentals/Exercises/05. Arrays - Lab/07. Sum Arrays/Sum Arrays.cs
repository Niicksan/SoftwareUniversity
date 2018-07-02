using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sumArray = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
