using System;

namespace HotelReservation
{
    public class PriceCalculator
    {
        private decimal pricePerNight;
        private int nights;
        private SeasonMultiplier seasonMultiplier;
        private Discount discount;

        public PriceCalculator(string[] information)
        {
            pricePerNight = decimal.Parse(information[0]);
            nights = int.Parse(information[1]);
            seasonMultiplier = Enum.Parse<SeasonMultiplier>(information[2]);
            discount = Discount.None;

            if (information.Length == 4)
            {
                discount = Enum.Parse<Discount>(information[3]);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal price = pricePerNight * nights * (int)seasonMultiplier;

            return price - price * (decimal)discount / 100;
        }
    }
}
