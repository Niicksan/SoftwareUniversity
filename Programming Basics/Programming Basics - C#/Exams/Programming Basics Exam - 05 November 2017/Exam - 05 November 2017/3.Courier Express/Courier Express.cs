﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgProduct = double.Parse(Console.ReadLine());
            var service = Console.ReadLine().ToLower();
            int km = int.Parse(Console.ReadLine());

            double price = 0;

            if (service == "standard")
            {
                if (kgProduct < 1.00)
                {
                    price = km * 0.03;
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 1 && kgProduct <= 10)
                {
                    price = km * 0.05;
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 11 && kgProduct <= 40)
                {
                    price = km * 0.10;
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 41 && kgProduct <= 90)
                {
                    price = km * 0.15;
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 91 && kgProduct <= 150)
                {
                    price = km * 0.20;
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }
            }

            else
            {
                if (kgProduct < 1.00)
                {
                    price = (km * 0.03) + (km * (kgProduct * (0.03 * 0.80)));
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 1 && kgProduct <= 10)
                {
                    price = (km * 0.05) + (km * (kgProduct * (0.05 * 0.40)));
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 11 && kgProduct <= 40)
                {
                    price = (km * 0.10) + (km * (kgProduct * (0.10 * 0.05)));
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 41 && kgProduct <= 90)
                {
                    price = (km * 0.15) + (km * (kgProduct * (0.15 * 0.02)));
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }

                else if (kgProduct >= 91 && kgProduct <= 150)
                {
                    price = (km * 0.20) + (km * (kgProduct * (0.20 * 0.01)));
                    Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", kgProduct, price);
                }
            }
        }
    }
}
