using System;
using System.Text.RegularExpressions;

namespace _03._Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            MatchCollection hexNumbers = Regex.Matches(input, pattern);

            foreach (Match item in hexNumbers)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
