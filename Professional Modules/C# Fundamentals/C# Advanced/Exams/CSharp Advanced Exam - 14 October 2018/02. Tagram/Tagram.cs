using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Tagram
{
    class Tagram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> tagram = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length > 2)
                {
                    string username = tokens[0];
                    string tag = tokens[1];
                    int likes = int.Parse(tokens[2]);

                    if (!tagram.ContainsKey(username))
                    {
                        tagram.Add(username, new Dictionary<string, int>());
                    }

                    if (!tagram[username].ContainsKey(tag))
                    {
                        tagram[username].Add(tag, 0);
                    }

                    tagram[username][tag] += likes;
                }
                else if (tokens.Length < 3)
                {
                    string[] ban = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string username = ban[1];

                    if (tagram.ContainsKey(username))
                    {
                        tagram.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var username in tagram.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Keys.Count))
            {
                Console.WriteLine(username.Key);
                foreach (var post in username.Value)
                {
                    Console.WriteLine($"- {post.Key}: {post.Value}");
                }
            }
        }
    }
}
