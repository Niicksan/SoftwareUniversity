using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int yearMoney = 0;
            int moneyCount = 0;

            for (int bday = 1; bday <= age; bday++)
            {
                if (bday % 2 == 0)
                {
                    moneyCount++;
                    money += 10;
                    yearMoney += money;
                }

                else
                {
                    toys++;
                }
            }

            int totalPriceToys = toys * priceToy;
            int totalMoney = yearMoney + totalPriceToys - moneyCount;
            double difference = Math.Abs(totalMoney - price);

            if (totalMoney >= price)
            {
                Console.WriteLine("Yes! {0:f2}", difference);
            }

            else
            {
                Console.WriteLine("No! {0:f2}", difference);
            }
        }
    }
}
