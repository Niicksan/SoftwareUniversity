using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<long>>>
                army = new Dictionary<string, Dictionary<string, List<long>>>();

            while (n-- > 0)
            {
                string[] data = Console.ReadLine().Split();

                string type = data[0];
                string name = data[1];

                long damage = data[2].Equals("null") ? 45 : long.Parse(data[2]);
                long health = data[3].Equals("null") ? 250 : long.Parse(data[3]);
                long armor= data[4].Equals("null") ? 10 : long.Parse(data[4]);

                List<long> stats = new List<long>();
                stats.Add(damage);
                stats.Add(health);
                stats.Add(armor);

                if (!army.ContainsKey(type))
                {
                    army.Add(type, new Dictionary<string, List<long>>());

                }
                
                army[type][name] = stats;
            }

            foreach (var type in army.Keys)
            {
                double sumDmg = 0;
                double sumHealth = 0;
                double sumArmor = 0;

                Dictionary<string, List<long>> nameWithStats =
                    army[type];

                foreach (var inner in nameWithStats)
                {
                    sumDmg += nameWithStats[inner.Key][0];
                    sumHealth += nameWithStats[inner.Key][1];
                    sumArmor += nameWithStats[inner.Key][2];
                }

                Console.WriteLine($"{type}::({sumDmg / nameWithStats.Count:F2}/{sumHealth / nameWithStats.Count:F2}/{sumArmor / nameWithStats.Count:F2})");

                foreach (var item in nameWithStats.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }
            }
        }
    }
}