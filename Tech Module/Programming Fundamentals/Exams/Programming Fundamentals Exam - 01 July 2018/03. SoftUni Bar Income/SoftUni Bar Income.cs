using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%([A-z][a-z]+)%<([\w]+)+>\|(\d)\|(\d+\.\d+)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = Regex.Matches(input, pattern);

            if ()
            {

            }

        }
    }
}
