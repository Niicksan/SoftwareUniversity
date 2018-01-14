using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());

            int sofiaWeekend = 48 - weekendsHome;
            double playSofia = 3.0 * sofiaWeekend / 4 * 2.0 * holidays / 4;
            int playHome = weekendsHome;
            double playTotal = playSofia + playHome;

            if (year.Equals("leap"))
            {
                playTotal = Math.Truncate(playTotal * 15 / 100 + playTotal);
            }

            else if (year.Equals("normal"))
            {
                playTotal = Math.Truncate(playTotal);
            }

            Console.WriteLine(playTotal);

        }
    }
}
