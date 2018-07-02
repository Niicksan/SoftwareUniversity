using System;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                string result = GetEscapeSequence(item);
                Console.Write(result);
            }
            Console.WriteLine();
        }

        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
