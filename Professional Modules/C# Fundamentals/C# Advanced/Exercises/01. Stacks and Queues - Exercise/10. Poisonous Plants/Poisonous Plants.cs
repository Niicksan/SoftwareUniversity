using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> indexes = new List<int>();

            int n = int.Parse(Console.ReadLine());

            List<int> plants = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int days = 0;

            while (true)
            {
                for (int i = 1; i < plants.Count; i++)
                {
                    if (plants[i] > plants[i - 1])
                    {
                        indexes.Add(i);
                    }
                }

                if (indexes.Count == 0)
                {
                    break;
                }

                int count = 0;

                for (int i = 0; i < indexes.Count; i++)
                {
                    plants.RemoveAt(indexes[i] - count);
                    count++;
                }

                days++;
                indexes.Clear();              
            }

            Console.WriteLine(days);
        }
    }
}
