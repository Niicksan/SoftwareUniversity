using System;
using System.Globalization;

namespace _01._Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDateStr = Console.ReadLine();
            string endDataStr = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact
                (startDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact
                (endDataStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] noneWorking = new DateTime[]
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 10, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };

            int countWorkDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (!(i.DayOfWeek == DayOfWeek.Sunday) && 
                    !(i.DayOfWeek == DayOfWeek.Saturday))
                {

                    countWorkDays++;
                    foreach (var item in noneWorking)
                    {
                        if ((i.Day == item.Day) && (i.Month == item.Month))
                        {
                            countWorkDays--;
                        }
                    }
                }
            }

            Console.WriteLine(countWorkDays);
        }
    }
}
