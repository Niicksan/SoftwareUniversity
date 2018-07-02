using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> mainSet = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> mainCache = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                string[] splitedData = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitedData.Length != 1)
                {
                    string key = splitedData[0];
                    long size = long.Parse(splitedData[1]);
                    string set = splitedData[2];

                    if (mainSet.ContainsKey(set) == false)
                    {
                        if (mainCache.ContainsKey(set) == false)
                        {
                            mainCache.Add(set, new Dictionary<string, long>());
                        }

                        if (!mainCache[set].ContainsKey(key))
                        {
                            mainCache[set].Add(key, 0);
                        }

                        mainCache[set][key] += size;
                    }
                    else
                    {
                        mainSet[set].Add(key, size);
                    }
                }
                else
                {
                    string set = splitedData[0];

                    if (mainSet.ContainsKey(set) == false)
                    {
                        mainSet.Add(set, new Dictionary<string, long>());
                    }

                    if (mainCache.ContainsKey(set))
                    {
                        mainSet[set] = mainCache[set];
                    }
                }

                input = Console.ReadLine();
            }

            if (mainSet.Count > 0)
            {
                KeyValuePair<string, Dictionary<string, long>> highestSet = mainSet.OrderByDescending(x => x.Value.Values.Sum()).First();

                Console.WriteLine($"Data Set: {highestSet.Key}, Total Size: {highestSet.Value.Values.Sum()}");

                foreach (var kvp in highestSet.Value)
                {
                    Console.WriteLine($"$.{kvp.Key}");
                }
            }
        }
    }
}
