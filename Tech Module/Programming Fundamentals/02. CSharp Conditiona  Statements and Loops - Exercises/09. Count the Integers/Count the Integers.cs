using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int counter = 0;

            try
            {
                while (true)
                {
                    int num = int.Parse(input);
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
