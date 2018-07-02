using System;

namespace _07._Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            long items = long.Parse(Console.ReadLine());

            decimal moneySpent = 0;

            for (long i = 1; i <= items; i++)
            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                long itemQuantity = long.Parse(Console.ReadLine());

                if (itemQuantity == 1)
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName} to cart.");

                }
                else
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName}s to cart.");
                }

                moneySpent += itemPrice * itemQuantity;
            }

            decimal diff = Math.Abs(budget - moneySpent);

            Console.WriteLine($"Subtotal: ${moneySpent:F2}");
            if (budget > moneySpent)
            {
                Console.WriteLine($"Money left: ${diff:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${diff:F2} more.");
            }
        }
    }
}
