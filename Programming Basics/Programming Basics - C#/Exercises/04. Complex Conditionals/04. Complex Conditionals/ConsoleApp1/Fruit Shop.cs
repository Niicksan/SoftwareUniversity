using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Input:
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round(2.50 * quantity, 2));
                }

                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round(1.20 * quantity, 2));
                }
               
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round(0.85 * quantity, 2));
                }
                
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round(1.45 * quantity, 2));
                }
                
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round(2.70 * quantity, 2));
                }

                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round(5.50 * quantity, 2));
                }

                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round(3.85 * quantity, 2));
                }

                else
                {
                    Console.WriteLine("error");
                }
            }
            
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round(2.70 * quantity, 2)); 
                }

                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round(1.25 * quantity, 2));
                }

                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round(0.90 * quantity, 2));
                }

                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round(1.60 * quantity, 2)); 
                }

                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round(3.00 * quantity, 2)); 
                }

                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round(5.60 * quantity, 2));
                }

                else if (fruit == "grapes")
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

            goto Input;
        }
    }
}
