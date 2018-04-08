using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Emergency_Repairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong wall = ulong.Parse(Console.ReadLine());
            int emergencyKits = int.Parse(Console.ReadLine());
            int attacks = int.Parse(Console.ReadLine());

            for (uint i = 1; i <= attacks; i++)
            {
                int attackedBit = int.Parse(Console.ReadLine());
                wall = wall & ~((ulong)1 << attackedBit);
            }

            for (int i = 0; i <= 63; i++)
            {
                ulong bit = (wall >> i) & 1;
                if (bit == 0 && emergencyKits > 0)
                {
                    bool foundHole = false;
                    while (emergencyKits > 0 && i + 1 < 64 && ((wall >> (i + 1) & 1)) == 0);
                    {
                        wall = wall | ((ulong)1 << i);
                        i++;
                        emergencyKits--;
                        foundHole = true;
                    }
                    if (foundHole && emergencyKits > 0)
                    {
                        wall = wall | ((ulong)1 << i);
                        emergencyKits--;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
