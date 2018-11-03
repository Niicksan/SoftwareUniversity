using System;

namespace HotelReservation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] information = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            PriceCalculator priceCalculator = new PriceCalculator(information);

            Console.WriteLine(priceCalculator.GetTotalPrice().ToString("F2"));
        }
    }
}
