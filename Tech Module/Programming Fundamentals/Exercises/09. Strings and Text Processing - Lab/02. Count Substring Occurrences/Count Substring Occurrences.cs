using System;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int index = text.IndexOf(pattern);
            int count = 0;

            while (index != -1)
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
