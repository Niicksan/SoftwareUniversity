using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int aMeters = int.Parse(Console.ReadLine());
            int bMeters = int.Parse(Console.ReadLine());

            double hNet = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double longNet = 2 * (aMeters + bMeters);
            double priceNet = longNet * price;
            double areaNet = longNet * hNet;
            double weightNet = areaNet * weight;

            Console.WriteLine(longNet);
            Console.WriteLine(string.Format("{0:f2}", priceNet));
            Console.WriteLine(string.Format("{0:f3}", weightNet));
        }
    }
}
