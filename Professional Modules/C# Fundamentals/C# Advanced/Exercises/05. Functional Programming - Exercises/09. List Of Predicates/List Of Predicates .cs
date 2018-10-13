using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
               .Split()
               .Distinct()
               .Select(int.Parse)
               .ToList();

            List<int> numbers = new List<int>();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            dividers.ForEach(d => predicates.Add(x => x % d == 0));

            for (int i = 1; i <= range; i++)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}