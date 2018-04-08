using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Beer_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservedBeers = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            long countBeers = 0;
            long countSixpacks = 0;
            long countCases = 0;

            while (command != "Exam Over")
            {
                string[] commandElements = command.Split(' ');
                long amount = long.Parse(commandElements[0]);
                string type = (commandElements[1]);

                if (type == "beers")
                {
                    countBeers += amount;
                }
                else if (type == "sixpacks")
                {
                    countSixpacks += amount * 6;
                }
                else if (type == "cases")
                {
                    countCases += amount * 24;
                }

                command = Console.ReadLine();
            }

            long beers = countBeers + countSixpacks + countCases;

            if (beers >= 100)
            {
                beers = beers - (beers / 100);
            }

            long totalBeersLeft = Math.Abs(reservedBeers - beers);
            long casesLeft = totalBeersLeft / 24;
            totalBeersLeft %= 24;
            long sixpacksLeft = totalBeersLeft / 6;
            long beersLeft = totalBeersLeft % 6;

            if (beers >= reservedBeers)
            {
                Console.WriteLine($"Cheers! Beer left: {casesLeft} cases, {sixpacksLeft} sixpacks and {beersLeft} beers.");
            }
            else
            {
                Console.WriteLine($"Not enough beer. Beer needed: {casesLeft} cases, {sixpacksLeft} sixpacks and {beersLeft} beers.");
            }
        }
    }
}
