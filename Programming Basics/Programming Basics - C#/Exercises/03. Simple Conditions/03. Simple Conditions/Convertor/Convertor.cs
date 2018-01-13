using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            input:
            var size = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine().ToLower();
            var deskMetric = Console.ReadLine().ToLower();

            if (sourceMetric == "km")
            {
                size = size / 0.001;
            }

            if (sourceMetric == "mi")
            {
                size = size / 0.000621371192;
            }

            else if (sourceMetric == "in")
            {
                size = size / 39.3700787;
            }

            else if (sourceMetric == "cm")
            {
                size = size / 100;
            }

            else if (sourceMetric == "mm")
            {
                size = size / 1000;
            }

            else if (sourceMetric == "ft")
            {
                size = size / 3.2808399;
            }

            else if (sourceMetric == "yd")
            {
                size = size / 1.0936133;
            }


            if (deskMetric == "km")
            {
                size = size * 0.001;
            }

            if (deskMetric == "mi")
            {
                size = size * 0.000621371192;
            }

            if (deskMetric == "in")
            {
                size = size * 39.3700787;
            }

            if (deskMetric == "cm")
            {
                size = size * 100;
            }
        
            if (deskMetric == "mm")
            {
                size = size * 1000;
            }

            if (deskMetric == "ft")
            {
                size = size * 3.2808399;
            }

            if (deskMetric == "yd")
            {
                size = size * 1.0936133;
            }

            Console.WriteLine(size + " " + deskMetric);

            goto input;
        }
    }
}
