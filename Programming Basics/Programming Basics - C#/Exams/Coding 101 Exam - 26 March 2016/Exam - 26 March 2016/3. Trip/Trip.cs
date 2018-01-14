using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double monney = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            double percentage = 0;
            if (monney <= 100)
            {
                if (season == "summer")
                {
                    percentage = monney * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - " + string.Format("{0:f2}", percentage));
                }

                else
                {
                    percentage = monney * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - " + string.Format("{0:f2}", percentage));
                }
            }

            else if (monney > 100 && monney <= 1000)
            {
                if (season == "summer")
                {
                    percentage = monney * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - " + string.Format("{0:f2}", percentage));
                }

                else
                {
                    percentage = monney * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - " + string.Format("{0:f2}", percentage));
                }
            }

            else
            {
                percentage = monney * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - " + string.Format("{0:f2}", percentage));
            }
        }
    }
}
