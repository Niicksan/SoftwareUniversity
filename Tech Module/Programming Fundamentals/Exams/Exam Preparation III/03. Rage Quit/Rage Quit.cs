using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\D+)(\d+)");

            string line = Console.ReadLine().ToUpper();

            StringBuilder result = new StringBuilder();

            MatchCollection matches = regex.Matches(line);
            foreach (Match match in matches)
            {
                string word = match.Groups[1].Value;
                int repeat = int.Parse(match.Groups[2].Value);

                StringBuilder final = RepeatString(word, repeat);
                result.Append(final);
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }

        public static StringBuilder RepeatString(string word, int repeat)
        {
            StringBuilder result = new StringBuilder(); ;

            for (int i = 0; i < repeat; i++)
            {
                result.Append(word);
            }

            return result;
        }
    }
}