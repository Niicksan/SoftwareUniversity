using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine()
                .Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}
