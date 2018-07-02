using System;

namespace _09._Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
