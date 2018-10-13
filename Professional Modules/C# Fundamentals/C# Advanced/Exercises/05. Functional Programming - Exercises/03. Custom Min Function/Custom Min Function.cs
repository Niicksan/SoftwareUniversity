using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> findMin = x => x.Min();

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(findMin(numbers));
        }
    }
}