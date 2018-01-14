using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancer = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string places = Console.ReadLine().ToLower();

            double prize;
            double cost = 0;
            if (places == "bulgaria")
            {
                prize = points * dancer;
                if (season == "summer")
                {
                    cost += 0.05;
                }

                else
                {
                    cost += 0.08;
                }
            }

            else
            {
                prize = (points * dancer) + ((points * dancer) * 0.50);
                if (season == "summer")
                {
                    cost += 0.10;
                }

                else
                {
                    cost += 0.15;
                }
            }

            double money = prize - (prize * cost);
            double cherity = money * 0.75;
            double moneyLeft = money - cherity;
            double moneyPerDancer = moneyLeft / dancer;

            Console.WriteLine("Charity - {0:f2}", cherity);
            Console.WriteLine("Money per dancer - {0:f2}", moneyPerDancer);
        }
    }
}
