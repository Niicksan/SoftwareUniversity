using System;
using System.Text.RegularExpressions;

namespace _04._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b(\d{2})([.\-\/])([A-Z][a-z]{2})\2(\d{4})\b");

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                var day = item.Groups[1].Value;
                var month = item.Groups[3].Value;
                var year = item.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
