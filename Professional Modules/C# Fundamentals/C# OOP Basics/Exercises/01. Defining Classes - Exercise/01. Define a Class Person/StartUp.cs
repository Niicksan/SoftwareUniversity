using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person person = new Person();
            person.Name = name;
            person.Age = age;

            Console.WriteLine($"{person.Name} is {person.Age} years old");
        }
    }
}
