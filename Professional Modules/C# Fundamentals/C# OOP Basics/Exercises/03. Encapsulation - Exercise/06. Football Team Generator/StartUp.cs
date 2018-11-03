using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Team> teamsData = new Dictionary<string, Team>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "Team")
                {
                    string teamName = tokens[1];

                    if (!teamsData.ContainsKey(teamName))
                    {
                        try
                        {
                            Team team = new Team(teamName);
                            teamsData.Add(teamName, team);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                    }
                }
                else if (command == "Add")
                {
                    string teamName = tokens[1];

                    if (!teamsData.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        continue;
                    }

                    string playerName = tokens[2];
                    int endurane = int.Parse(tokens[3]);
                    int sprint = int.Parse(tokens[4]);
                    int dribble = int.Parse(tokens[5]);
                    int passing = int.Parse(tokens[6]);
                    int shooting = int.Parse(tokens[7]);

                    Player player = null;

                    try
                    {
                        Stats stats = new Stats(endurane, sprint, dribble, passing, shooting);
                        player = new Player(playerName, stats);

                        Team team = teamsData[teamName];
                        team.AddPlayer(player);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Remove")
                {
                    string teamName = tokens[1];
                    string playerName = tokens[2];

                    if (teamsData.ContainsKey(teamName))
                    {
                        Team team = teamsData[teamName];
                        team.RemovePlayer(playerName);
                    }
                }
                else if (command == "Rating")
                {
                    string teamName = tokens[1];

                    if (!teamsData.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        continue;
                    }

                    Team team = teamsData[teamName];
                    Console.WriteLine($"{team.Name} - {Math.Round(team.Rating)}");
                }
            }
        }
    }
}
