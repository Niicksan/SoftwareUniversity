using System;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] normal = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] revered = new string[normal.Length];

            for (int i = normal.Length - 1; i >= 0; i--)
            {
                Console.Write(normal[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
