using System;

namespace _01._Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greeting(name);
        }

        private static void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
