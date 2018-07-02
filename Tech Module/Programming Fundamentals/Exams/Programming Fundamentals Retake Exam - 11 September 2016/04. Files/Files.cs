using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] lineTokens = line.Split('\\');

                string root = lineTokens[0].Trim();
                string file = lineTokens[lineTokens.Length - 1].Trim();
                string[] splitted = file.Split(';');
                string fileName = splitted[0].Trim();
                long fileSize = long.Parse(splitted[1]);

                if (!dict.ContainsKey(root))
                {
                    dict.Add(root, new Dictionary<string, long>());
                }

                if (!dict[root].ContainsKey(fileName))
                {
                    dict[root].Add(fileName, fileSize);
                }
                else
                {
                    dict[root][fileName] = fileSize;
                }

            }

            string[] find = Console.ReadLine().Split();

            string searchedRoot = find[2];
            string searchedEx = find[0];

            if (dict.ContainsKey(searchedRoot))
            {
                Dictionary<string, long> result = dict[searchedRoot];

                if (result.Count == 0)
                {
                    Console.WriteLine("No");
                    return;
                }
                foreach (var kvp in result.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
                {
                    if (kvp.Key.EndsWith(searchedEx))
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}