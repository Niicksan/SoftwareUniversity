using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double percentage = X * 0.40;
            double kg = percentage * Y;
            double wineLiters = kg / 2.5;

            if (wineLiters < Z)
            {
                double wineLacked = Math.Floor(Z - wineLiters);
                Console.WriteLine("It will be a tough winter! More {0:0} liters wine needed.", wineLacked);
            }

            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineLiters));
                double wineLeft = Math.Ceiling(wineLiters - Z);
                double winePerPerson = Math.Ceiling(wineLeft / workers);

                Console.WriteLine("{0} liters left -> {1} liters per person.", wineLeft, winePerPerson);
            }
        }
    }
}
