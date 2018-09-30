using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = line[0];
                string clothesPackage = line[1];

                string[] clothes = clothesPackage.Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < clothes.Length; j++)
                {
                    string item = clothes[j];

                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }

                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }

                    wardrobe[color][item]++;
                }
            }

            string[] find = Console.ReadLine().Split();

            string findColor = find[0];
            string findItem = find[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (color.Key == findColor && item.Key == findItem)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                } 
            }
        }
    }
}
