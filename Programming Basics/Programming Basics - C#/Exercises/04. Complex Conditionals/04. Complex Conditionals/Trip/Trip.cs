using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double moneyNeeded = 0;
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneyNeeded = budget * 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    moneyNeeded = budget * 0.7;
                    place = "Hotel";
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneyNeeded = budget * 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    moneyNeeded = budget * 0.8;
                    place = "Hotel";
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                moneyNeeded = budget * 0.9;
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:0.00}", place, moneyNeeded);
        }
    }
}
