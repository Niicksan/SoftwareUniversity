using System;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            var result = DateTime.ParseExact(date, format, null);
            result = result.AddDays(999);

            var day = result.Day.ToString("00");
            var month = result.Month.ToString("00");
            var year = result.Year;

            Console.WriteLine("{0}-{1}-{2}", day, month, year);
        }
    }
}
