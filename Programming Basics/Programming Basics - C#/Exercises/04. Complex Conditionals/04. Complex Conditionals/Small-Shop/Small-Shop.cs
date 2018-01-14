using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            input:
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            
            if (product == "coffee")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(0.45 * quantity);
                }
            }

            else if (product == "water")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(0.80 * quantity);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(0.70 * quantity);
                }
            }

            else if (product == "beer")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(1.20 * quantity);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(1.10 * quantity);
                }
            }

            else if (product == "sweets")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(1.35 * quantity);
                }
            }

            else if (product == "peanuts")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(1.60 * quantity);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(1.50 * quantity);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }

            goto input;
        }
    }
}
