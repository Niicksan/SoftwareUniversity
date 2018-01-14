using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            int num = 2;
            if (n <= 1)
            {
                isPrime = false;
   
            }

            while (num <= Math.Sqrt(n))
            {
                
                if (n % num == 0)
                {
                    isPrime = false;
                    break;
                }
                num ++;
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }

            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
