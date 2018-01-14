using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int olds = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string vehiclе = Console.ReadLine().ToLower();

            double ticketPrice = 0;
            double hotelPrice = 0;

            if (vehiclе == "train")
            {
                if (olds + students >= 50)
                {
                    ticketPrice = ((olds * (24.99 / 2)) + (students * (14.99 / 2))) * 2;
                    hotelPrice = nights * 82.99;
                }

                else
                {
                    ticketPrice = ((olds * 24.99) + (students * 14.99)) * 2;
                    hotelPrice = nights * 82.99;
                }
            }

            else if (vehiclе == "bus")
            {
                ticketPrice = ((olds * 32.50) + (students * 28.50)) * 2;
                hotelPrice = nights * 82.99;
            }

            else if (vehiclе == "boat")
            {
                ticketPrice = ((olds * 42.99) + (students * 39.99)) * 2;
                hotelPrice = nights * 82.99;
            }

            else if (vehiclе == "airplane")
            {
                ticketPrice = ((olds * 70.00) + (students * 50.00)) * 2;
                hotelPrice = nights * 82.99;
            }

            double commission = (ticketPrice + hotelPrice) * 0.10;
            double totalPrice = ticketPrice + hotelPrice + commission;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
