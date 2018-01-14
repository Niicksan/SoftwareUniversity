using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDig = (number / 100);
            int secondDig = (number / 10) % 10;
            int lastDig = number % 10;

            int rows = firstDig + secondDig;
            int cols = firstDig + lastDig;

            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDig;
                    }

                    else if (number % 3 == 0)
                    {
                        number -= secondDig;
                    }

                    else
                    {
                        number += lastDig;
                    }
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}
