using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double priceApartment = 0.00;
            double priceStudio = 0.00;

            if (month == "may" || month == "october")
            {
                if (nights <= 7)
                {
                    priceApartment = 65 * nights;
                    priceStudio = 50 * nights;
                }

                else if (nights > 7 && nights <= 14)
                {
                    priceApartment = 65 * nights;
                    priceStudio = (50 - (50 * 0.05)) * nights;
                }

                else if (nights > 14)
                {
                    priceApartment = (65 - (65 * 0.10)) * nights;
                    priceStudio = (50 - (50 * 0.30)) * nights;
                }
            }

            else if (month == "june" || month == "september")
            {
                if (nights <= 14)
                {
                    priceApartment = 68.70 * nights;
                    priceStudio = 75.20 * nights;
                }

                else
                {
                    priceApartment = (68.70 - (68.70 * 0.10)) * nights;
                    priceStudio = (75.20 - (75.20 * 0.20)) * nights;
                }
            }

            else if (month == "july" || month == "august")
            {
                if (nights <= 14)
                {
                    priceApartment = 77 * nights;
                    priceStudio = 76 * nights;
                }

                else
                {
                    priceApartment = (77 - (77 * 0.10)) * nights;
                    priceStudio = 76 * nights;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", priceApartment);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
    }
}
