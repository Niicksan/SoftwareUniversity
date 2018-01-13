using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetotpr = int.Parse(Console.ReadLine());
            int secondCompetotpr = int.Parse(Console.ReadLine());
            int thirdCompetotpr = int.Parse(Console.ReadLine());

            int seconds = firstCompetotpr + secondCompetotpr + thirdCompetotpr;
            int minutes = 0;

            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }

            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }

            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
