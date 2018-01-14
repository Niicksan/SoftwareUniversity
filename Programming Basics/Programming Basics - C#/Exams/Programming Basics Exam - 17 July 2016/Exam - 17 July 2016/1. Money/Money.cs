using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chines = double.Parse(Console.ReadLine());
            double com = double.Parse(Console.ReadLine());
            double comission = com / 100;

            int bitToLeva = bitcoins * 1168;
            double chinesToLeva = (chines * 0.15) * 1.76;

            double sum = (bitToLeva + chinesToLeva) / 1.95;
            double sumTotal = sum - (sum * comission);
            Console.WriteLine(string.Format("{0:F2}", sumTotal));
        }
    }
}
