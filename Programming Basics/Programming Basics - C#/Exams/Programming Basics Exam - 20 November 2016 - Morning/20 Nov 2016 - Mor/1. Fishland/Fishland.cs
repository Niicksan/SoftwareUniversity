using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double mackerel = double.Parse(Console.ReadLine());
            double sprat = double.Parse(Console.ReadLine());
            double bonito = double.Parse(Console.ReadLine());
            double horseМackerel = double.Parse(Console.ReadLine());
            double mussels = double.Parse(Console.ReadLine());

            double priceBonito = mackerel + mackerel * 0.60;
            double priceHorseMackerel = sprat + sprat * 0.80;
            double priceMussels = mussels * 7.50;

            double totalPrice = bonito * priceBonito + horseМackerel * priceHorseMackerel + priceMussels;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
