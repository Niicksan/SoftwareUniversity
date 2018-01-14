using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieces = int.Parse(Console.ReadLine());
            double moneyPrize = double.Parse(Console.ReadLine());

            double totalPoints = 0;
            for (int i = 1; i <= pieces; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    totalPoints += points * 2;
                }

                else
                {
                    totalPoints += points;
                }
            }

            double prize = moneyPrize * totalPoints;
            Console.WriteLine("The project prize was {0:f2} lv.", prize);
        }
    }
}
