using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = "";
            double price = 0;
            double discount = 0;

            if (groupSize <= 50)
            {
                hall += "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                hall += "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                hall += "Great Hall";
                price += 7500;
            }
            else
	        {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "Normal":
                    price += 500;
                    discount += 0.95;
                    break;
                case "Gold":
                    price += 750;
                    discount += 0.90;
                    break;
                case "Platinum":
                    price += 1000;
                    discount += 0.85;
                    break;
            }
            price *= discount;

            double pricePerPerson = price / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
