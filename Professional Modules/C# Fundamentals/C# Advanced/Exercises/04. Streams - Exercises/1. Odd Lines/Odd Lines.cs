using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../../files/text.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();

                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine($"{line}");
                    }

                    counter++;

                    line = reader.ReadLine();
                }
            }
        }
    }
}
