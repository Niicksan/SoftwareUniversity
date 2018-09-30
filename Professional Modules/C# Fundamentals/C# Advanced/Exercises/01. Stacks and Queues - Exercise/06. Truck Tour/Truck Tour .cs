using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPump = new Queue<int[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] petrolStation = Console.ReadLine().Split().Select(int.Parse).ToArray();

                petrolPump.Enqueue(petrolStation);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var currentStation in petrolPump)
                {
                    int fuel = currentStation[0];
                    int distance = currentStation[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        int[] pumpToRemove = petrolPump.Dequeue();
                        petrolPump.Enqueue(pumpToRemove);
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }
        }
    }
}
