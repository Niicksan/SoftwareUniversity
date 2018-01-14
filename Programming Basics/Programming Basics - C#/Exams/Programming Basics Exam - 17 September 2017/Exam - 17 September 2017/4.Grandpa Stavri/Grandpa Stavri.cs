using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalLiters = 0;
            double Degrees = 0;

            for (int row = 1; row <= days; row++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                totalLiters += liters;
                Degrees += liters * degrees;
            }

            double totalDegree = Degrees / totalLiters;
            Console.WriteLine("Liter: {0:f2}", totalLiters);
            Console.WriteLine("Degrees: {0:f2}", totalDegree);

            if (totalDegree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }

            else if (totalDegree >= 38 && totalDegree <= 42)
            {
                Console.WriteLine("Super!");
            }

            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
