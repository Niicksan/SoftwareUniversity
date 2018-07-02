using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Awesome_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int favNumber = int.Parse(Console.ReadLine());

            bool even = false;
            bool odd = false;
            bool negative = false;
            bool module = false;

            if (number % 2 == 0)
            {
                even = true;
            }
            else
            {
                odd = true;
            }

            if (number < 0)
            {
                negative = true;
            }

            if (number % favNumber == 0)
            {
                module = true;
            }

            if (odd && negative && module)
            {
                Console.WriteLine("super special awesome");
            }

            else if ((odd && negative) || (odd && module) || (negative && module))
            {
                Console.WriteLine("super awesome");
            }

            else if (odd || negative ||module)
            {
                Console.WriteLine("awesome");
            }

            else
            {
                Console.WriteLine("boring");
            }
        }
    }
}
