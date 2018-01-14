using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());

            int evenDayEvenHours = 0;
            int OddDayOddHours = 0;
            int EvenDayOddHours = 0;
            int oddDayEvenHours = 0;
            for (int i = 1; i <= days; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (hours % 2 == 0)
                    {
                        OddDayOddHours += 68 * dancers;
                    }

                    else
                    {
                        oddDayEvenHours += 65 * dancers;
                    }
                }

                else
                {
                    if (hours % 2 == 0)
                    {
                        EvenDayOddHours += 49 * dancers;
                    }

                    else
                    {
                        evenDayEvenHours += 30 * dancers;
                    }
                }
            }

            int energy = 100 * dancers * days;
            double energyLeft = energy - (evenDayEvenHours + OddDayOddHours +
                                       EvenDayOddHours + oddDayEvenHours);

            double dancerEnergy = energyLeft / dancers / days;

            if (dancerEnergy <= 50)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", dancerEnergy);
            }

            else
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", dancerEnergy);
            }
        }
    }
}
