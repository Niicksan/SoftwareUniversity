using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (var pair in input)
            {
                string[] tokens = pair.Split('=');

                try
                {
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);

                    Person person = new Person(name, money);
                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var pair in input)
            {
                string[] tokens = pair.Split('=');

                try
                {
                    string name = tokens[0];
                    decimal cost = decimal.Parse(tokens[1]);

                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = tokens[0];
                string productName = tokens[1];

                Person person = persons.Single(p => p.Name == personName);
                Product product = products.Single(p => p.Name == productName);

                if (!person.BuyProduct(product))
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }

                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                string productsBought = person.Products.Count == 0 ? "Nothing bought" : String.Join(", ", person.Products.Select(p => p.Name));

                Console.WriteLine($"{person.Name} - {productsBought}");
            }
        }
    }
}
