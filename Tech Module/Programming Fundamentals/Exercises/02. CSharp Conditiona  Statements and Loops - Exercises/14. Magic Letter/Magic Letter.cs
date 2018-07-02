using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char j = firstLetter; j <= secondLetter; j++)
            {
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    for (char l = firstLetter; l <= secondLetter; l++)
                    {
                        if (j == thirdLetter || k == thirdLetter || l == thirdLetter)
                        {
                            continue;
                        }
                        Console.Write($"{j}{k}{l} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
