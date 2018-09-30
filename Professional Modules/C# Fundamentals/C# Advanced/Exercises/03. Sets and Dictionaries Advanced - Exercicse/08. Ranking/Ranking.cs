using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            bool isEnteredInnerWjle = true;

            while (input != "end of submissions")
            {              
                while (input != "end of contests" && isEnteredInnerWjle)
                {
                    string[] elements = input.Split(":", StringSplitOptions.None).ToArray();

                    string course = elements[0];
                    string password = elements[1];

                    if (!contests.ContainsKey(course))
                    {
                        contests.Add(course, password);
                    }

                    input = Console.ReadLine();
                }

                if (input == "end of contests")
                {
                    isEnteredInnerWjle = false;
                    input = Console.ReadLine();
                }

                string[] tokens = input.Split("=>", StringSplitOptions.None).ToArray();

                string contest = tokens[0];
                string pasword = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contest) && contests[contest] == pasword)
                {
                    if (!results.ContainsKey(username))
                    {
                        results.Add(username, new Dictionary<string, int>());
                    }

                    if (!results[username].ContainsKey(contest))
                    {
                        results[username].Add(contest, 0);
                    }

                    if (results[username][contest] < points)
                    {
                        results[username][contest] = points;
                    }   
                }

                input = Console.ReadLine();
            }

            long maxPoints = long.MinValue;
            string user = "";

            foreach (var username in results)
            {
                long sum = 0;

                foreach (var points in username.Value)
                {
                    sum += points.Value;
                }

                if (sum > maxPoints)
                {
                    maxPoints = sum;
                    user = username.Key;
                }
            }

            Console.WriteLine($"Best candidate is {user} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var username in results.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{username.Key}");

                foreach (var contest in username.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}