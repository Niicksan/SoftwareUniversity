using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string size = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            int liters = 0;
            double price = 0;
            switch (fruit)
            {
                case "watermelon":
                    if (size == "small")
                    {
                        liters += 2;
                        price += 56;
                    }

                    else
                    {
                        liters += 5;
                        price += 28.70;
                    }
                    break;

                case "mango":
                    if (size == "small")
                    {
                        liters += 2;
                        price += 36.66;
                    }

                    else
                    {
                        liters += 5;
                        price += 19.60;
                    }
                    break;

                case "pineapple":
                    if (size == "small")
                    {
                        liters += 2;
                        price += 42.10;
                    }

                    else
                    {
                        liters += 5;
                        price += 24.80;
                    }
                    break;

                case "raspberry":
                    if (size == "small")
                    {
                        liters += 2;
                        price += 20;
                    }

                    else
                    {
                        liters += 5;
                        price += 15.20;
                    }
                    break;
            }

            double totalPrice = liters * price * number;
            if (totalPrice < 400)
            {
                totalPrice = totalPrice * 1;
            }

            else if (totalPrice > -400 && totalPrice <= 1000)
            {
                totalPrice = totalPrice * 0.85;
            }

            else
            {
                totalPrice = totalPrice * 0.50;
            }

            Console.WriteLine("{0:f2} lv.", totalPrice);
        }
    }
}
