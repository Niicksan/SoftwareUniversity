using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = GetPersons();

            PrintPerson(persons);
        }

        private static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                Person  person = persons.FirstOrDefault(p => p.Name == name);

                if (person == null)
                {
                    person = new Person(name);
                    persons.Add(person);
                }

                string subclass = tokens[1];

                switch (subclass)
                {
                    case "company": // <Name> company <companyName> <department> <salary>
                        string companyName = tokens[2];
                        string department = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);
                            person.Company = new Company(companyName, department, salary);
                        break;
                    case "car": // <Name> car <carModel> <carSpeed>   
                        string carModel = tokens[2];
                        int carSpeed = int.Parse(tokens[3]);
                            person.Car = new Car(carModel, carSpeed);
                        break;
                    case "pokemon": // <Name> pokemon <pokemonName> <pokemonType>  
                        string pokemonName = tokens[2];
                        string pokemonType = tokens[3];
                            person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        break;
                    case "parents": // <Name> parents <parentName> <parentBirthday>    
                        string parentName = tokens[2];
                        string parentBirthday = tokens[3];
                            person.Parents.Add(new FamilyMember(parentName, parentBirthday));
                        break;
                    case "children": // <Name> children <childName> <childBirthday>
                        string childName = tokens[2];
                        string childBirthday = tokens[3];
                            person.Children.Add(new FamilyMember(childName, childBirthday));
                        break;                  
                    default: break;
                }

                input = Console.ReadLine();
            }
            return persons;
        }

        private static void PrintPerson(List<Person> persons)
        {
            string  name = Console.ReadLine();

            Person person = persons.FirstOrDefault(p => p.Name == name);

            if (person != null)
            {
                Console.Write(person.ToString());
            }
        }
    }
}
