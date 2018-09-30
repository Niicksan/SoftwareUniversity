using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (!lettersCount.ContainsKey(letter))
                {
                    lettersCount.Add(letter, 0);
                }

                lettersCount[letter]++;
            }

            foreach (var letter in lettersCount.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
