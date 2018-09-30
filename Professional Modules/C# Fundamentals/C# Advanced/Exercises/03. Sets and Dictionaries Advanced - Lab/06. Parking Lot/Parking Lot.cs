using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lots = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> carNumbers = new HashSet<string>();

            while (lots[0] != "END")
            {
                string car = lots[0];
                string number = lots[1];

                if (car == "IN")
                {
                    carNumbers.Add(number);
                }
                else if (car == "OUT")
                {
                    if (carNumbers.Contains(number))
                    {
                        carNumbers.Remove(number);
                    }
                }

                lots = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count != 0)
            {
                foreach (var number in carNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
