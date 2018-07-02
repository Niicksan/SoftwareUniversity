using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                long sum = hornets.Sum();

                if (beehives[i] < sum)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= sum;
                    hornets.RemoveAt(0);
                }
            }

            Console.WriteLine(beehives.Sum() > 0 ? string.Join(" ", beehives.Where(x => x != 0)) : string.Join(" ", hornets));
        }
    }
}