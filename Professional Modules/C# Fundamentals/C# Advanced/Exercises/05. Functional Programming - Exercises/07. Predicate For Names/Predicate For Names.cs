using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> filter = x => x.Length <= length;

            foreach (var name in names.Where(x => filter(x)))
            {
                Console.WriteLine(name);
            }
        }
    }
}