using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Lutenica
{
    class Lutenica
    {
        static void Main(string[] args)
        {
            double kgTomatos = double.Parse(Console.ReadLine());
            int kasetki = int.Parse(Console.ReadLine());
            int jars = int.Parse(Console.ReadLine());

            double kgLutenica = kgTomatos / 5;
            double jarsCount = kgLutenica / 0.535;
            double boxes = jarsCount / jars;
            double difference = Math.Floor(Math.Abs(kasetki - boxes));
            double diffjars = Math.Floor(Math.Abs(jarsCount - (kasetki * jars)));

            if (boxes > kasetki)
            {
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(kgLutenica));
                Console.WriteLine("{0} boxes left.", difference);
                Console.WriteLine("{0} jars left.", diffjars);
            }

            else
            {
                Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(kgLutenica));
                Console.WriteLine("{0} more boxes needed.", difference);
                Console.WriteLine("{0} more jars needed.", diffjars);
            }
        }
    }
}
