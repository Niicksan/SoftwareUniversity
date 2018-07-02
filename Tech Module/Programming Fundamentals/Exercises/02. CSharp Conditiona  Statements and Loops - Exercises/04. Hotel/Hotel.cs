using System;

namespace _04._Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;

            double discount = 1;

            if (month == "May" || month == "October")
            {
                if (nights > 7)
                {
                    discount *= 0.95;
                }

                studio = (50 * discount) * nights;
                doubleRoom = 65 * nights;
                suite = 75 * nights;

                if (month == "October" && nights > 7)
                {
                    studio -= 50 * discount;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    discount *= 0.90;
                }

                studio = 60 * nights;
                doubleRoom = (72 * discount) * nights;
                suite = 82 * nights;

                if (month == "September" && nights > 7)
                {
                    studio -= 60 * discount;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nights > 14)
                {
                    discount *= 0.85;
                }
                studio = 68 * nights;
                doubleRoom = 77 * nights;
                suite = (89 * discount) * nights;
            }

            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}
