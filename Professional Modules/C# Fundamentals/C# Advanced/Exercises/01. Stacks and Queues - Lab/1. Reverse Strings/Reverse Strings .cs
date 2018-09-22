using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversed = new Stack<char>();

            foreach (var ch in input)
            {
                reversed.Push(ch);
            }
            while (reversed.Count != 0)
            {
                Console.Write(reversed.Pop());
            }
            Console.WriteLine();

        }
    }
}
