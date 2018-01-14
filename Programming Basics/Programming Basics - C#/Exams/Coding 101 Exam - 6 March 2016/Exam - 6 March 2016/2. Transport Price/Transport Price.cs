using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dayNight = Console.ReadLine();

            double price = 0;

            if (n < 20)
            {
                if (dayNight == "day")
                {
                    price = 0.70 + (0.79 * n);
                }

                else
                {
                    price = 0.70 + (0.90 * n);
                }
            }

            else if (n >= 20 && n < 100)
            {
                price = 0.09 * n;
            }

            else
            {
                price = 0.06 * n;
            }

            Console.WriteLine(price);
        }
    }
}
