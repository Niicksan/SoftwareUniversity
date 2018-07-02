using System;
using System.Collections.Generic;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string word1 = tokens[0];
            string word2 = tokens[1];


            if (word1.Length >= word2.Length)
            {
                MapWords(word1, word2);
            }
            else
            {
                MapWords(word2, word1);
            }
        }

        private static void MapWords(string word1, string word2)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            for (int i = 0; i < word2.Length; i++)
            {
                char firstWordChar = word1[i];
                char secondWordChar = word2[i];

                if (!map.ContainsKey(firstWordChar))
                {
                    map[firstWordChar] = secondWordChar;
                }
                else if (map[firstWordChar] != secondWordChar)
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            for (int i = word2.Length; i < word1.Length; i++)
            {
                char firstWordChar = word1[i];

                if (!map.ContainsKey(firstWordChar))
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
        }
    }
}
