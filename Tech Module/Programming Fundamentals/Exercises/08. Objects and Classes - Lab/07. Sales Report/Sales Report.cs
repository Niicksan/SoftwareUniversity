using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, List<Sale>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string town = input.Split()[0];
                if (!sales.ContainsKey(town))
                    sales[town] = new List<Sale>();
                sales[town].Add(new Sale(input));
            }

            foreach (var sale in sales)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value.Sum(s => s.Multiply()):f2}");
            }
        }
    }

    internal class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Sale(string input)
        {
            var split = input.Split();
            Product = split[1];
            Price = decimal.Parse(split[2]);
            Quantity = decimal.Parse(split[3]);
        }

        public decimal Multiply()
        {
            return Price * Quantity;
        }

    }
}
