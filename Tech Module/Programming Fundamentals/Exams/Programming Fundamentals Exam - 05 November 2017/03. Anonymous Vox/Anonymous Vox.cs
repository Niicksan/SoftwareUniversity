using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Anonymous_Vox
{
    class Program
    {
        public static object MatchCollections { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @"(?<starEnd>[A-Za-z]+)(.+)(\k<starEnd>)";

            string inputText = Console.ReadLine();
            List<string> placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            MatchCollection matches = Regex.Matches(inputText, pattern);

            foreach (Match matched in matches)
            {
                string match = matched.ToString();

                string placeholder = matched.Groups["placeholder"].Value.ToString();
                string newBlock = matched.Groups["startEnd"].Value + placeholders[0] + matched.Groups["startEnd"].Value;

                inputText = inputText.Replace(match, newBlock);

                placeholders.RemoveAt(0);
            }
        }
    }
}
