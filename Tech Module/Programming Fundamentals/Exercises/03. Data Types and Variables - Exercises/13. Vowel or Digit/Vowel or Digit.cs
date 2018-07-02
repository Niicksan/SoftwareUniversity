using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine().ToLower();

            int number = 0;

            bool isDigit = int.TryParse(symbol, out number);

            if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
