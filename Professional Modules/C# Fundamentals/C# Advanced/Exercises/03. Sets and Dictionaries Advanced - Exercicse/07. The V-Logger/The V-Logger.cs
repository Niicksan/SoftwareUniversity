using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> youTube = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (line[0] != "Statistics")
            {
                string action = line[1];

                if (action == "joined")
                {
                    string newVlogger = line[0];

                    if (!youTube.ContainsKey(newVlogger))
                    {
                        youTube.Add(newVlogger, new Dictionary<string, HashSet<string>>());
                        youTube[newVlogger].Add("following", new HashSet<string>());
                        youTube[newVlogger].Add("followers", new HashSet<string>());
                    }
                }
                else if (action == "followed")
                {
                    string vloggerIsFollowing = line[0];
                    string vloggerToFollow = line[2];

                    if (vloggerIsFollowing != vloggerToFollow)
                    {

                        if (youTube.ContainsKey(vloggerIsFollowing) && youTube.ContainsKey(vloggerToFollow))
                        {
                            youTube[vloggerIsFollowing]["following"].Add(vloggerToFollow);
                            youTube[vloggerToFollow]["followers"].Add(vloggerIsFollowing);
                        }
                    }
                }

                line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            int number = 1;

            Console.WriteLine($"The V-Logger has a total of {youTube.Keys.Count} vloggers in its logs.");

            foreach (var vlogger in youTube.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(v => v))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }
        }
    }
}