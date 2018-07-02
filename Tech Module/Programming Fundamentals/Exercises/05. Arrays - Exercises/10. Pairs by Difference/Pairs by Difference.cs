using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int pairs = 0;

            for (int outerIndex = 0; outerIndex < array.Length - 1; outerIndex++)
            {
                int a = array[outerIndex];
                for (int innerIndex = outerIndex + 1; innerIndex < array.Length; innerIndex++)
                {
                    int b = array[innerIndex];

                    if (Math.Abs(a - b) == diff)
                    {
                        pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
