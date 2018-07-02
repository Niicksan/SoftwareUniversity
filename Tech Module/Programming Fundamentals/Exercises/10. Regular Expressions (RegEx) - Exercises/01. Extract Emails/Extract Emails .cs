using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        public static object Machcollection { get; private set; }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = $@" (([^._\- ]?[\w\-]+\.)?[^._-][\w-]+[^._-]@[a-z][a-z\-]+\.[a-z]+(\.[a-z]+)?)";

            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(text);

            foreach (Match item in match)
            {
                Console.WriteLine(item.Value.Trim());
            }
        }
    }
}
