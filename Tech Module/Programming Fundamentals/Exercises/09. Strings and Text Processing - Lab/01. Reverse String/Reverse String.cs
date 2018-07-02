using System;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                result += word[word.Length - 1 - i];
            }

            Console.WriteLine(result);
        }
    }
}
