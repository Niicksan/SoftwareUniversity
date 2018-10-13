using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            //TODO: Read data from console
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(", ").ToArray();

                string name = line[0];
                int age = int.Parse(line[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, age);
                }
            }

            string condition = Console.ReadLine();
            int compareAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> filter = CreateFilter(condition, compareAge);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            PrintFilteredStudent(people, filter, printer);
        }

        private static void PrintFilteredStudent(Dictionary<string, int> people, Func<int, bool> filter, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var kv in people)
            {
                if (filter(kv.Value))
                {
                    printer(kv);
                }
            }
        }

        public static Func<int, bool> CreateFilter(string condition, int compareAge)
        {
            switch (condition)
            {
                case "younger": return x => x < compareAge;
                case "older": return x => x >= compareAge;
                default: return null;
            }
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            { 
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person => Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }
    }
}