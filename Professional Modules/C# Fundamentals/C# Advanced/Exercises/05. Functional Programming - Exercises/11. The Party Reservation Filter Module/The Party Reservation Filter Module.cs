using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            
            List<string> filtered = new List<string>();
            List<string> result = new List<string>(names);

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, string, bool> contains = (a, b) => a.Contains(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            string[] commandArgs = Console.ReadLine().Split(';');

            while (commandArgs[0] != "Print")
            {
                string operation = commandArgs[0];
                string filter = commandArgs[1];
                string letter = commandArgs[2];

                switch (filter)
                {
                    case "Starts with":
                        filtered = names
                            .Where(i => startsWith(i, letter))
                            .ToList();
                        break;
                    case "Ends with":
                        filtered = names
                            .Where(i => endsWith(i, letter))
                            .ToList();
                        break;
                    case "Length":
                        filtered = names
                            .Where(i => checkLength(i, int.Parse(letter)))
                            .ToList();
                        break;
                    case "Contains":
                        filtered = names
                            .Where(i => contains(i, letter))
                            .ToList();
                        break;
                }

                switch (operation)
                {
                    case "Add filter":
                        result
                            .RemoveAll(r => filtered.Contains(r));
                        break;
                    case "Remove filter":
                        result.AddRange(filtered);
                        result = result.Distinct().ToList();
                        break;
                }

                commandArgs = Console.ReadLine().Split(';');
            }

            names.RemoveAll(i => !result.Contains(i));

            Console.WriteLine(String.Join(" ", names));
        }
    }
}