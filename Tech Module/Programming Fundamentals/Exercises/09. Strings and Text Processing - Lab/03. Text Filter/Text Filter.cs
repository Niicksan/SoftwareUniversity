using System;

namespace _03._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] patterns = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in patterns)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
