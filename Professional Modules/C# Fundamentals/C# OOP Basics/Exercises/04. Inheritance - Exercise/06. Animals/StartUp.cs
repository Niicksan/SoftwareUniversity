using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                try
                {
                    Animal animal = GetAnimal(animalType);
                    Console.Write(animal.ToString());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static Animal GetAnimal(string animalType)
        {
            string[] tokens = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string animalName = tokens[0];
            int animalAge = int.Parse(tokens[1]);

            switch (animalType)
            {
                case "Cat":
                    return new Cat(animalName, animalAge, tokens[2]);
                case "Dog":
                    return new Dog(animalName, animalAge, tokens[2]);
                case "Frog":
                    return new Frog(animalName, animalAge, tokens[2]);
                case "Kitten":
                    return new Kitten(animalName, animalAge);
                case "Tomcat":
                    return new Tomcat(animalName, animalAge);
                default:
                    throw new ArgumentException("Invalid input!"); // NB!
            }
        }
    }
}