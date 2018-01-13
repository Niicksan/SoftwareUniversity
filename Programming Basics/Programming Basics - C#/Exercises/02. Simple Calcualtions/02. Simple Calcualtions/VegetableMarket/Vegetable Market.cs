using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            uint vegetableKg = uint.Parse(Console.ReadLine());
            uint fruitKg = uint.Parse(Console.ReadLine());

            double sumLv = n * vegetableKg + m * fruitKg;
            double sumEuro;
            sumEuro = sumLv / 1.94;

            Console.WriteLine(sumEuro);
        }
    }
}
