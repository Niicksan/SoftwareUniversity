using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionInfo = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] hornetArmadaData = input.Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(hornetArmadaData[0]);
                string legionName = hornetArmadaData[1];
                string soldierType = hornetArmadaData[2];
                long soldierCount = long.Parse(hornetArmadaData[3]);

                if (!legionInfo.ContainsKey(legionName))
                {
                    legionInfo.Add(legionName, new Dictionary<string, long>());
                    legionActivity.Add(legionName, lastActivity);
                }

                if (!legionInfo[legionName].ContainsKey(soldierType))
                {
                    legionInfo[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    legionInfo[legionName][soldierType] += soldierCount;
                }

                if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }
            }

            string soldier = Console.ReadLine();

            if (soldier.IndexOf('\\') != -1)
            {
                int activity = int.Parse(soldier.Substring(0, soldier.IndexOf('\\')));
                string soldierType = soldier.Substring(soldier.IndexOf('\\') + 1);

                foreach (var legion in legionInfo
                    .Where(e => legionInfo[e.Key].ContainsKey(soldierType))
                    .OrderByDescending(e => e.Value[soldierType]))
                {
                    if (legionActivity[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
                    }
                }

            }
            else
            {
                foreach (var item in legionActivity.OrderByDescending(x => x.Value))
                {
                    if (legionInfo[item.Key].ContainsKey(soldier))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}
