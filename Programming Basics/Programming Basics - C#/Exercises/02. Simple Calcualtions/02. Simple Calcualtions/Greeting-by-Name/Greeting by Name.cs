using System;

namespace Greeting_by_Name
{
    class Program
    {
        static void Main(string[] args)
        {
         // Console.WriteLine("Enter your name ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
