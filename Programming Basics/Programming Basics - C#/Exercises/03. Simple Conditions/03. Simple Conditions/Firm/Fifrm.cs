using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Fifrm
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double availableDays = (days * 0.90);
            double workingHours = availableDays * 8;
            double overtimeHours = days * 2 * workers;
            double totalHoures = Math.Floor(workingHours + overtimeHours);
            double difference = Math.Abs(hours - totalHoures);

            if (totalHoures >= hours)
            {
                Console.WriteLine(
                    $"Yes!{difference} hours left.");
            }

            else
            {
                Console.WriteLine(
                    $"Not enough time!{difference} hours needed.");

            }
        }
    }
}
