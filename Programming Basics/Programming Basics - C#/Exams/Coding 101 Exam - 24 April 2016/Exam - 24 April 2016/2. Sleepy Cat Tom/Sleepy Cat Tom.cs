using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sleepy_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int workingDays = 365 - days;
            int totalPlay = (days * 127 + workingDays * 63);
            int difference = Math.Abs(30000 - totalPlay);
            var hours = difference / 60;
            var minutes = difference % 60;

            if (totalPlay < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }

            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}