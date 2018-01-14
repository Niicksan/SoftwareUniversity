using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            input:
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());


            if (fruit == "banana")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(2.50 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(2.70 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (fruit == "apple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(1.20 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(1.25 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (fruit == "orange")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(0.85 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(0.90 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (fruit == "grapefuit")
            { 
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(1.45 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(1.50 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (fruit == "kiwi")
            { 
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(2.70 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(3.00 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (fruit == "pineapple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(5.50 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(5.60 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (fruit == "grapes")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    Console.WriteLine(Math.Round(3.85 * quantity, 2));
                }

                else if (day == "Saturday" || day == "Sunday")
                {
                    Console.WriteLine(Math.Round(4.20 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }

            goto input;
        }
    }
}
