using System;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(name, age);

            Console.WriteLine($"{person.Name} is {person.Age} years old");
        }
    }
}
