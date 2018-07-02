using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\b[^.?!]*?\b{word}\b.*?(?=[.!?])";

            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match);
            }
        }
    }
}
