using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { '.', ',', ';', ':', '!', '(', ')',
                                  '"', '\'', '\\', '/', '[', ']', ' '};
            List<string> input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (var word in input)
            {
                var lowercaseLetters = 0;
                var uppercaseLetters = 0;

                foreach (var letter in word)
                {
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        uppercaseLetters++;
                    }
                    else if (letter >= 'a' && letter <= 'z')
                    {
                        lowercaseLetters++;
                    }
                }

                if (word.Length == lowercaseLetters)
                {
                    lowerCaseWords.Add(word);
                }
                else if (word.Length == uppercaseLetters)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
