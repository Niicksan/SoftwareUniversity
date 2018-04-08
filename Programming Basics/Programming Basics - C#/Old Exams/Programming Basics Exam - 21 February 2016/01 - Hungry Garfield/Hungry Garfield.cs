using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal dollarRate = decimal.Parse(Console.ReadLine());

            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());

            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal moneyForPizza = (pizzaPrice * pizzaQuantity) / dollarRate;
            decimal moneyForLasagna = (lasagnaPrice * lasagnaQuantity) / dollarRate;
            decimal moneyForSandwiches = (sandwichPrice * sandwichQuantity) / dollarRate;

            decimal moneySpent = moneyForPizza + moneyForLasagna + moneyForSandwiches;
            decimal moneyLeft = Math.Abs(money - moneySpent);

            if (moneySpent <= money)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${moneyLeft:f2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${moneyLeft:f2}.");
            }
        }
    }
}
