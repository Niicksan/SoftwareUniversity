using System;

namespace Stars_of_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            input:
            Console.Write("Enter a number between 2 and 100");
            Console.WriteLine("");

            var n = int.Parse(Console.ReadLine());

            if (n < 2 || n > 100)
            {
                Console.WriteLine("Enter a valid number");
                goto input;
            }
            else

            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', n));
            goto input;
        }
    }
}
