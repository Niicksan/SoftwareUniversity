using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string condition = Console.ReadLine();

            List<int> numbers = new List<int>();

            Enumerable.Range(range[0], range[1] - range[0] + 1)
                .Where(x => condition == "even" ? isEven(x) : !isEven(x))
                .ToList()
                .ForEach(numbers.Add);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
