﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();

            double percentage = 1;
            double price;
            if (roomType == "apartment")
            {
                price = (days - 1) * 25.00;

                if (days < 10)
                {
                    percentage *= 0.70;
                }

                else if (days >= 10 && days <= 15)
                {
                    percentage *= 0.65;
                }

                else
                {
                    percentage *= 0.50;
                }
            }

            else if (roomType == "president apartment")
            {
                price = (days - 1) * 35.00;

                if (days < 10)
                {
                    percentage *= 0.90;
                }

                else if (days >= 10 && days <= 15)
                {
                    percentage *= 0.85;
                }

                else
                {
                    percentage *= 0.80;
                }
            }

            else
            {
                price = (days - 1) * 18.00;
                percentage *= 1.00;
            }

            double perPrice = price * percentage;
            double totalPrice;

            if (review == "positive")
            {
                totalPrice = perPrice + (perPrice * 0.25);
            }

            else
            {
                totalPrice = perPrice - (perPrice * 0.10);
            }

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}