using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                int code = word[i] - 97;
                Console.WriteLine($"{word[i]} -> {code}");
            }
        }
    }
}
