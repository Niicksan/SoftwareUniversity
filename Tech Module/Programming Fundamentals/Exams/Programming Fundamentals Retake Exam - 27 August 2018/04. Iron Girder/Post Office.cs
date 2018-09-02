using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            
            Dictionary<string, int> townsPassengers = new Dictionary<string, int>{};
            Dictionary<string, int> townsTimes = new Dictionary<string, int>();

            while (line != "Slide rule")
            {
                string[] train = line.Split(new[] { ":", "->", }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (train[1] != "ambush")
                {
                    string townName = train[0];
                    int bestTime = int.Parse(train[1]);
                    int totalCountPassengers = int.Parse(train[2]);

                    if (!townsPassengers.ContainsKey(townName))
                    {
                        townsPassengers.Add(townName, totalCountPassengers);
                        townsTimes.Add(townName, bestTime);
                    }

                    else if (townsTimes.ContainsKey(townName))
                    {
                        if (townsTimes[townName] > bestTime)
                        {
                            townsTimes[townName] = bestTime;
                        }
                        if (townsTimes[townName] == 0)
                        {
                            townsTimes[townName] = bestTime;
                        }
                        townsPassengers[townName] += totalCountPassengers;
                    }          
                }
                else if (train[1] == "ambush")
                {
                    string townName = train[0];;
                    int totalCountPassengers = int.Parse(train[2]);

                    if (townsTimes.ContainsKey(townName))
                    {
                        townsTimes[townName] = 0;                        
                        townsPassengers[townName] -= totalCountPassengers;
                    }
                }         

                line = Console.ReadLine();
            }

            bool timeZero = false;
            bool passZero = false;

            foreach (var time in townsTimes)
            {
                if (time.Value == 0)
                {
                    timeZero = true;
                }
            }

            foreach (var pass in townsPassengers)
            {
                if (pass.Value == 0)
                {
                    passZero = true;
                }
            }
            foreach (var town in townsTimes.Where(time => !time.Value.Equals(0)).OrderBy(time => time.Value).ThenBy(town => town.Key))
            {
                Console.Write($"{town.Key} -> Time: { town.Value} -> ");
                foreach (var passengers in townsPassengers)
                {
                    if (passengers.Key == town.Key)
                    {
                        Console.WriteLine($"Passengers: {passengers.Value}");
                    }
                }
            }
        }
    }
}
