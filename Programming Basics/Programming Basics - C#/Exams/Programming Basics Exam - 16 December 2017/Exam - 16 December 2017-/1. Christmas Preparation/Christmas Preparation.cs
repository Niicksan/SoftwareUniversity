﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollsPpaper = int.Parse(Console.ReadLine());
            int rollsTextile = int.Parse(Console.ReadLine());
            double litersGlue = double.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());

            double priceRollsPapper = rollsPpaper * 5.80;
            double priceRollsTextile = rollsTextile * 7.20;
            double priceGlue = litersGlue * 1.20;
            double price = priceRollsPapper + 
                    priceRollsTextile + priceGlue;

            double totalPrice = price - ((price * percentage) / 100);

            Console.WriteLine("{0:f3}", totalPrice);
        }
    }
}
