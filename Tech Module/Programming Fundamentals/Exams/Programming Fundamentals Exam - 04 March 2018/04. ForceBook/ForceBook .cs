using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                string pattern = " | ";
                string patternn = " -> ";
                string[] force = input.Split(new[] { pattern, patternn }, StringSplitOptions.None).ToArray();

                string first = force[0];
                string second = force[1];

                List<string> forceUser = new List<string>();

                if (input.Contains("|"))
                {
                    if (!forceBook.ContainsKey(first))
                    {
                        forceBook.Add(first, new List<string>());
                    }

                    else
                    {
                        forceBook[first].Add(second);
                    }

                    if (!forceBook[first].Contains(second))
                    {
                        forceBook[first].Add(second);
                    }
                }
                else if (input.Contains("->"))
                {
                    if (!forceBook.ContainsKey(second))
                    {
                        forceBook.Add(second, new List<string>());
                    }

                    if (forceBook.ContainsKey(second))
                    {
                        foreach (var side in forceBook.Values)
                        {
                            if (side.Contains(first))
                            {
                                side.Remove(first);
                            }
                        }                   

                        if (!forceBook[second].Contains(first))
                        {
                            forceBook[second].Add(first);
                            Console.WriteLine($"{first} joins the {second} side!");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var side in forceBook.OrderByDescending(side => side.Value.Count).ThenBy(name => name.Key))
            {
                if (side.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var forceUser in side.Value.OrderBy(user => user))
                    {
                        Console.WriteLine($"! {forceUser}");
                    }
                }
            }
        }
    }
}
