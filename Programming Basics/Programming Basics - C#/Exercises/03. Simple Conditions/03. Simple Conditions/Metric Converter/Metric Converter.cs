using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            double toMeter;
            double result;
            //m, mi, in, km, ft, yd
            if (value1 == value2)
            {
                result = distance;
            }
            else
            {
                if (value1 == "mm")
                {
                    toMeter = distance / 1000;
                }
                else if (value1 == "cm")
                {
                    toMeter = distance / 100;
                }
                else if (value1 == "mi")
                {
                    toMeter = distance / 0.000621371192;
                }
                else if (value1 == "mi")
                {
                    toMeter = distance / 0.000621371192;
                }
                else if (value1 == "in")
                {
                    toMeter = distance / 39.3700787;
                }
                else if (value1 == "km")
                {
                    toMeter = distance / 0.001;
                }
                else if (value1 == "ft")
                {
                    toMeter = distance / 3.2808399;
                }
                else if (value1 == "yd")
                {
                    toMeter = distance / 1.0936133;
                }
                else
                {
                    toMeter = distance;
                }


                if (value2 == "mm")
                {
                    result = toMeter * 1000;
                }
                else if (value2 == "cm")
                {
                    result = toMeter * 100;
                }
                else if (value2 == "mi")
                {
                    result = toMeter * 0.000621371192;
                }
                else if (value2 == "mi")
                {
                    result = toMeter * 0.000621371192;
                }
                else if (value2 == "in")
                {
                    result = toMeter * 39.3700787;
                }
                else if (value2 == "km")
                {
                    result = toMeter * 0.001;
                }
                else if (value2 == "ft")
                {
                    result = toMeter * 3.2808399;
                }
                else if (value2 == "yd")
                {
                    result = toMeter * 1.0936133;
                }
                else
                {
                    result = toMeter;
                }
            }
            Console.WriteLine("{0} {1}", result, value2);
        }
    }
}
