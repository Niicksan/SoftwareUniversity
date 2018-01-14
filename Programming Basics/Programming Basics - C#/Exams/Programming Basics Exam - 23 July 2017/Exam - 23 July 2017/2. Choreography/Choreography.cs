using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepPerDay = (steps / days) / steps;
            double stepPercentage = Math.Ceiling(stepPerDay * 100);
            double stepPerDancer = stepPercentage / dancers;

            if (stepPercentage <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", stepPerDancer);
            }

            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepPerDancer);
            }
        }
    }
}
