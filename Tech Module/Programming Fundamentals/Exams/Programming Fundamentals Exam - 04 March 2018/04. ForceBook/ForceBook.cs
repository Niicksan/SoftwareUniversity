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

                string[] tokens = input.Split(new[] { pattern, patternn }, StringSplitOptions.None).ToArray();

                if (input.Contains("|"))
                {
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                        forceBook[forceSide].Add(forceUser);
                    }

                    if (!forceBook[forceSide].Contains(forceUser))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];

                    foreach (var users in forceBook.Values)
                    {
                        if (users.Contains(forceUser))
                        {
                            users.Remove(forceUser);
                        }
                    }

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }

                    if (!forceBook[forceSide].Contains(forceUser))
                    {
                        forceBook[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var forceSide in forceBook.OrderByDescending(forceSide => forceSide.Value.Count).ThenBy(forceUser => forceUser.Key))
            {
                if (forceSide.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");
                    foreach (var forceUser in forceSide.Value.OrderBy(forceUser => forceUser))
                    {
                        Console.WriteLine($"! {forceUser}");
                    }
                }
            }
        }
    }
}
