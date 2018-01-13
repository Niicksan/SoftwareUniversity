using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort bitcoins = ushort.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double leva = bitcoins * (double)1168;
            double dollars = yuan * 0.15;
            double euro;
            double result;
            double commision_euro;

            leva = leva + (dollars * 1.76);
            euro = leva / 1.95;
            commision_euro = euro * (commision / 100);
            result = euro - commision_euro;

            Console.WriteLine(result);
        }
    }
}
