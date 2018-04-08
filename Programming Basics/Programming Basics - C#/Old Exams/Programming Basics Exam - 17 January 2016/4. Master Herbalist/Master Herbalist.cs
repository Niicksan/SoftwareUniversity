using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Master_Herbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyExpenses = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalMoney = 0;
            int days = 0;

            while (command != "Season Over")
            {
                days++;
                string[] gatheringHerbs = command.Split(' ');
                int hours = int.Parse(gatheringHerbs[0]);
                string path = gatheringHerbs[1];
                int moneyPerHerb = int.Parse(gatheringHerbs[2]);
                int herbs = 0;

                for (int i = 0; i < hours; i++)
                {
                    if (path[i % path.Length] == 'H')
                    {
                        herbs++;
                    }
                }
                totalMoney += herbs * moneyPerHerb;
                command = Console.ReadLine();
            }
            decimal moneyPerDay = (decimal)totalMoney / days;
            decimal extraMoney = moneyPerDay - dailyExpenses;
            decimal moreMoneyNeeded = (days * dailyExpenses) - totalMoney;
            if (moneyPerDay >= dailyExpenses)
            {
                Console.WriteLine($"Times are good. Extra money per day: {extraMoney:f2}.");
            }
            else
            {

                Console.WriteLine($"We are in the red. Money needed: {moreMoneyNeeded}.");
            }
        }
    }
}
