using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);

            List<int> nums = Console.ReadLine().Split(", ").Select(parser).ToList();

            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}
