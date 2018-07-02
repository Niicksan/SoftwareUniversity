using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Dictionary<string, long> mine = new Dictionary<string, long>();
            List<string> resourses = new List<string>();
            List<long> quantity = new List<long>();

            int count = 1;
            string currentResourse = "";
            string lastResourse = "";
            long lastQuantity = 0;

            while (line != "stop")
            {
                if (count % 2 == 1)
                {
                    currentResourse = "";
                    lastResourse = "";
                    lastQuantity = 0;

                    currentResourse = line;
                    lastResourse = currentResourse;
                }
                
                long currentQuantity = 0;

                if(count % 2 == 0)
                {
                    currentQuantity = long.Parse(line);
                    lastQuantity = currentQuantity;

                    if (!resourses.Contains(lastResourse))
                    {
                        resourses.Add(lastResourse);
                        quantity.Add(currentQuantity);
                    }
                    else
                    {
                        for (int i = 0; i < resourses.Count; i++)
                        {
                            if (resourses[i] == lastResourse)
                            {
                                quantity[i] += long.Parse(line);
                            }
                        }
                    }
                }

                count++;

                line = Console.ReadLine();
            }

            for (int i = 0; i < quantity.Count; i++)
            {
                mine.Add(resourses[i], quantity[i]);
            }

            foreach (var resource in mine)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
