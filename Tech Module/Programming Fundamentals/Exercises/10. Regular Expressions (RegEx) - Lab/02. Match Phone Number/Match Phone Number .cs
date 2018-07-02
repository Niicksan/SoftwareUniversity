using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string pattern = @"(\+359(\s+|-)2(\2)(\d{3})(\2)(\d{4}))\b";

            MatchCollection matches = Regex.Matches(phones, pattern);

            List<string> phone = new List<string>();
            foreach (Match item in matches)
            {
                phone.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", phone));
        }
    }
}
