using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", 
                Regex.Matches(Console.ReadLine(), 
                @"(^|(?<=\s))(-?)\d+(\.\d+)?($|(?=\s))")
                .Cast<Match>()
                .Select(e => e.Value.Trim())
                .ToArray()));
        }
    }
}
