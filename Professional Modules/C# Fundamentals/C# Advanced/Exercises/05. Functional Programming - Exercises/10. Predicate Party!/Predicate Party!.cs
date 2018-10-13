using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string[] commandArgs = Console.ReadLine().Split();

            List<string> filtered = new List<string>();

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            Func<List<string>, List<string>, List<string>> doublePeople = (a, b) =>
            {
                foreach (string doubled in b)
                {
                    for (int i = 0; i < a.Count * 2; i++)
                    {
                        if (i < a.Count)
                        {
                            if (a[i] == doubled)
                            {
                                a.Insert(i, doubled);
                                i++;
                            }
                        }
                    }
                }

                return a;
            };

            while (commandArgs[0] != "Party!")
            {
                string operation = commandArgs[0];
                string criteria = commandArgs[1];

                switch (criteria)
                {
                    case "StartsWith":
                        filtered = names
                            .Where(p => startsWith(p, commandArgs[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "EndsWith":
                        filtered = names
                            .Where(p => endsWith(p, commandArgs[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "Length":
                        filtered = names
                            .Where(p => checkLength(p, int.Parse(commandArgs[2])))
                            .Distinct()
                            .ToList();
                        break;
                }

                switch (operation)
                {
                    case "Remove":
                        names = names
                            .Where(p => !filtered.Contains(p))
                            .ToList();
                        break;
                    case "Double":
                        names = doublePeople(names, filtered);
                        break;
                }

                commandArgs = Console.ReadLine().Split();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
