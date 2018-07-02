using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int counter = 0;
            string result = "";
            bool isFound = false;
            for (int i = start; i <= stop; i++)
            {
                for (int k = start; k <= stop; k++)
                {
                    counter++;
                    if ((i + k) == magic)
                    {
                        isFound = true;
                        result = $"{i} + {k}";
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Number found! {result} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
