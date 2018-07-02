using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._NSA
{
    class NSA
    {
        static void Main(string[] args)
        {
            string nsa = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>>
                spies = new Dictionary<string, Dictionary<string, int>>();
            while (nsa != "quit")
            {
                string[] data = nsa.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string countryName = data[0];
                string spyName = data[1];
                int daysInService = int.Parse(data[2]);

                if (!spies.ContainsKey(countryName))
                {
                    spies.Add(countryName, new Dictionary<string, int>());

                }

                if (!spies[countryName].ContainsKey(spyName))
                {
                    spies[countryName][spyName] = daysInService;
                }

                spies[countryName][spyName] = daysInService;

                nsa = Console.ReadLine();
                
            }

            foreach (var countryName in spies.OrderByDescending(days => days.Value.Count))
            {
                Console.WriteLine($"Country: {countryName.Key}");

                foreach (var spy in countryName.Value.OrderByDescending(days => days.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
