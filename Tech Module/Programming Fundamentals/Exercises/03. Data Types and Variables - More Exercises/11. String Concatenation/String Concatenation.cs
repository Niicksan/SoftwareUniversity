using System;

namespace _11._String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());

            string concatenation = "";

            for (int i = 1; i <= lines; i++)
            {
                string element = Console.ReadLine();
                if (evenOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        concatenation += element + delimeter;
                    }
                }
                else if (evenOdd == "odd")
                {
                    if (i % 2 == 1)
                    {
                        concatenation += element + delimeter;
                    }
                }
                
            }
            concatenation = concatenation.Remove(concatenation.Length - 1);
            Console.WriteLine(concatenation);
        }
    }
}
