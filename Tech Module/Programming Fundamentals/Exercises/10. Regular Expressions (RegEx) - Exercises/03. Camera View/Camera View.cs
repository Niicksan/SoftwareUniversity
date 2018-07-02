using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = Regex.Split(Console.ReadLine(), "\\s").Select(x => int.Parse(x)).ToArray();
            int skip = count[0];
            int take = count[1];

            string input = Console.ReadLine();

            string pattern = @"(?<=\|<.{" + skip + "})([^|]{0," + take + "})";

            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(input);
            List<string> result = new List<string>();

            foreach (Match item in match)
            {
                result.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
