using System;
using System.Linq;

namespace _05._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\\', '\'', '/', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Where(el => el.Length < 5)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
