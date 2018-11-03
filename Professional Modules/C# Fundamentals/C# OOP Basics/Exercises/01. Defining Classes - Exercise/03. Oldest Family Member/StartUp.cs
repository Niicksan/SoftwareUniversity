using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);

                Person member = new Person(name, age);

                family.AddMember(member);
            }

            Person oldestMember = family.GetOldestMember();
            if (oldestMember != null)
            {
                Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            }
        }
    }
}
