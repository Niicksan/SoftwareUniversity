using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            string keysPattern = @"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$";

            Match keyMatch = Regex.Match(key, keysPattern);

            if (keyMatch.Success)
            {
                string startKey = keyMatch.Groups["startKey"].Value;
                string endKey = keyMatch.Groups["endKey"].Value;

                string textPattern = $@"{startKey}(?<word>.*?){endKey}";
                MatchCollection matches = Regex.Matches(text, textPattern);

                StringBuilder result = new StringBuilder();

                foreach (Match match in matches)
                {
                    result.Append(match.Groups["word"].Value);
                }

                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}
