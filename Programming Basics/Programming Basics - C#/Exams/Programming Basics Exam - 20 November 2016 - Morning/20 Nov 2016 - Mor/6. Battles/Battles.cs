using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            int count = 0;
            for (int p1 = 1; p1 <= firstPlayer; p1++)
            {
                for (int p2 = 1; p2 <= secondPlayer; p2++)
                {
                    if (count == maxBattles)
                    {
                        break;
                    }

                    Console.Write("({0} <-> {1}) ", p1, p2);
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
