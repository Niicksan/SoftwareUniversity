using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> awards = new Dictionary<string, Dictionary<string, int>>();

            while (command != "dawn")
            {
                string[] tokens = command.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (names.Contains(name))
                {
                    if (songs.Contains(song))
                    {
                        if (!awards.ContainsKey(name))
                        {
                            awards.Add(name, new Dictionary<string, int>());
                            awards[name].Add(award, 0);
                        }

                        if (!awards[name].ContainsKey(award))
                        {
                            awards[name].Add(award, 0);
                        }

                        if(awards[name].ContainsKey(award))
                        {
                            awards[name][award]++;
                        }
                    }
                }

                command = Console.ReadLine();               
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var name in awards.OrderByDescending(x => x.Value.Keys.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key}: {name.Value.Count()} awards");
                foreach (var award in name.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"--{award.Key}");
                }
            }
        }
    }
}
