using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double priceCakes = cakes * 45;
            double priceWafers = wafers * 5.80;
            double pricePancakes = pancakes * 3.20;

            double totalPrice = ((priceCakes + priceWafers + pricePancakes) * workers) * days;
            double moneyLeft = totalPrice - (0.125 * totalPrice);

            Console.WriteLine("{0:f2}", moneyLeft);
        }
    }
}
