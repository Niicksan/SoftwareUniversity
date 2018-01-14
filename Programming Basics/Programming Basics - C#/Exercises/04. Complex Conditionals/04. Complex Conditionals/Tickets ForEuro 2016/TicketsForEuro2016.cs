using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_ForEuro_2016
{
    class TicketsForEuro2016
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            uint peopleCount = uint.Parse(Console.ReadLine());

            double moneyForTransport;
            double moneyLeft;
            double moneyNeededForTickets;

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                moneyForTransport = budget * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                moneyForTransport = budget * 0.6;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                moneyForTransport = budget * 0.5;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                moneyForTransport = budget * 0.4;
            }
            else
            {
                moneyForTransport = budget * 0.25;
            }

            moneyLeft = budget - moneyForTransport;

            if (category == "normal")
            {
                moneyNeededForTickets = 249.99 * peopleCount;
                if (moneyLeft >= moneyNeededForTickets)
                {
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", moneyLeft - moneyNeededForTickets);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", moneyNeededForTickets - moneyLeft);
                }
            }
            else if (category == "vip")
            {
                moneyNeededForTickets = 499.99 * peopleCount;
                if (moneyLeft >= moneyNeededForTickets)
                {
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", moneyLeft - moneyNeededForTickets);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", moneyNeededForTickets - moneyLeft);
                }
            }
        }
    }
}
