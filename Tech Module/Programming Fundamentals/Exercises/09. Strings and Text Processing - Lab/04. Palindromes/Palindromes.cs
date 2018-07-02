using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split("!.,? ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            List<string> palindroms = new List<string>();
            foreach (var word in words)
            {
                bool isPalindrome = IsPalindrome(word);
                if (IsPalindrome(word))
                {
                    palindroms.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindroms.Distinct().OrderBy(x => x)));
        }

        private static bool IsPalindrome(string word)
        {
             for (int i = 0; i < word.Length; i++)
             {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
