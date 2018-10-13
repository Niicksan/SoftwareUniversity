using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\[[^\s\[\]]+<([\d]+)REGEH([0-9]+)>[^\s\[\]]+\]";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            int sum = 0;

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                int firstNum = int.Parse(match.Groups[1].Value);
                sum += firstNum;
                sb.Append(input[sum % (input.Length - 1)]);

                int secondNum = int.Parse(match.Groups[2].Value);
                sum += secondNum;
                sb.Append(input[sum % (input.Length - 1)]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
