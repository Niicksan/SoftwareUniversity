using System;

namespace _06._Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = (char)('a' + n);

            for (char firstLetter = 'a'; firstLetter < letter; firstLetter++)
            {
                for (char secondtLetter = 'a'; secondtLetter < letter; secondtLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < letter; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondtLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
