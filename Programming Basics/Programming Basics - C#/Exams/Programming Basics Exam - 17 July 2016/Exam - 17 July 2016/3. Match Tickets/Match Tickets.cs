using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            double moneyForTransport;
            double moneyLeft;
            double moneyNeededForTickets;


            if (people >= 1 && people <= 4)
            {
                moneyForTransport = budget * 0.75;
            }

            else if (people >= 5 && people <= 9)
            {
                moneyForTransport = budget * 0.60;
            }

            else if (people >= 10 && people <= 24)
            {
                moneyForTransport = budget * 0.50;
            }

            else if (people >= 25 && people <= 49)
            {
                moneyForTransport = budget * 0.40;
            }

            else
            {
                moneyForTransport = budget * 0.25;
            }

            moneyLeft = budget - moneyForTransport;

            if (category == "normal")
            {
                moneyNeededForTickets = 249.99 * people;
                double diff = Math.Abs(moneyLeft - moneyNeededForTickets);

                if (moneyLeft >= moneyNeededForTickets)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                }
            }

            else if (category == "vip")
            {
                moneyNeededForTickets = 499.99 * people;
                double diff = Math.Abs(moneyLeft - moneyNeededForTickets);

                if (moneyLeft >= moneyNeededForTickets)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                }
            }
        }
    }
}
