using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int kgVegPrice = int.Parse(Console.ReadLine());
            int kgFruitPrice = int.Parse(Console.ReadLine());

            double priceVeg = (vegPrice * kgVegPrice);
            double priceFruit = (fruitPrice * kgFruitPrice);

            double sum = (priceVeg + priceFruit) / 1.94;
            Console.WriteLine(sum);
        }
    }
}
