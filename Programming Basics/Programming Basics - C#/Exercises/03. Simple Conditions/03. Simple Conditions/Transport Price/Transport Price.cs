using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var time = Console.ReadLine().ToLower();

            var taxiBegingPrice = 0.70;
            var taxiDayPrice = 0.79;
            var taxiNightPrice = 0.90;

            var bus = 0.09;
            var train = 0.06;

            if (n < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
