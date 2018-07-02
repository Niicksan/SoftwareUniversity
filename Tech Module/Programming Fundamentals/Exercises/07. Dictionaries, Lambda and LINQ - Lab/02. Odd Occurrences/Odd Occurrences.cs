using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> countElem = new Dictionary<string, int>();

            foreach (var element in elements)
            {
                if (!countElem.ContainsKey(element))
                {
                    countElem.Add(element, 1);
                }
                else
                {
                    countElem[element]++;
                }
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> element in countElem)
            {
                if (element.Value % 2 != 0)
                {
                    result.Add(element.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
