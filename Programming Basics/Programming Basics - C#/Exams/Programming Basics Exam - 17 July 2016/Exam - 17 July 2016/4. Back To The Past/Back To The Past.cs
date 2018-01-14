using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int ageBoy = 18;

            double moneyNeeded = 0;

            for (int years = 1800; years <= year; years++)
            {
                if (years % 2 == 0)
                {
                    moneyNeeded += 12000;
                    ageBoy++;
                }

                else
                {
                    moneyNeeded += (12000 + (ageBoy * 50));
                    ageBoy++;
                }
            }

            if (moneyNeeded <= inheritance)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", inheritance - moneyNeeded);
            }

            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", moneyNeeded - inheritance);
            }
        }
    }
}
