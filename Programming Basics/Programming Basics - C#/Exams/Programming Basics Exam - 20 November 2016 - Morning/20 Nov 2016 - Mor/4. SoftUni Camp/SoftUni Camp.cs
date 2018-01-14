using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int car = 0;
            int minibus = 0;
            int smallBus = 0;
            int bigBus = 0;
            int train = 0;

            double totalPeople = 0;
            for (int row = 1; row <= groups; row++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    totalPeople += people;
                    car += people;
                }

                else if (people >= 6 && people <= 12)
                {
                    totalPeople += people;
                    minibus += people;
                }

                else if (people >= 13 && people <= 25)
                {
                    totalPeople += people;
                    smallBus += people;
                }

                else if (people >= 26 && people <= 40)
                {
                    totalPeople += people;
                    bigBus += people;
                }

                else
                {
                    totalPeople += people;
                    train += people;
                }
            }

            double carGroup = (car * 100) / totalPeople;
            double minibusGroup = (minibus * 100) / totalPeople;
            double smallBusgroup = (smallBus * 100) / totalPeople;
            double bigBusGroup = (bigBus * 100) / totalPeople;
            double trainGroup = (train * 100) / totalPeople;

            Console.WriteLine("{0:f2}%", carGroup);
            Console.WriteLine("{0:f2}%", minibusGroup);
            Console.WriteLine("{0:f2}%", smallBusgroup);
            Console.WriteLine("{0:f2}%", bigBusGroup);
            Console.WriteLine("{0:f2}%", trainGroup);
        }
    }
}
