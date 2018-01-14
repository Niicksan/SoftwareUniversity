using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 ==0)
                {
                    evenSum += element;
                }

                else
                {
                    oddSum += element;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = " + evenSum);
            }

            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
