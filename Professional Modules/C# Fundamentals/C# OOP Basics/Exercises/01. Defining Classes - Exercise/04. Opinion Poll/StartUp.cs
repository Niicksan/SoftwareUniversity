using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int numberOfPersons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPersons; i++)
            {
                string[] personInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                
                people.Add(person);

            }

            people = people.Where(n => n.Age > 30).OrderBy(a => a.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
