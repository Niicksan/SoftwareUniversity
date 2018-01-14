using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double dollars = double.Parse(Console.ReadLine());

            double montly = money * days;
            double yearly = montly * 12;
            double total = yearly + (2.5 * montly);
            double dds = total * 0.25;
            double Total = total - dds;
            double day = (Total / 365) * dollars;

            Console.WriteLine(string.Format("{0:f2}", day));
        }
    }
}
