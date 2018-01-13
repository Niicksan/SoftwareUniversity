using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Emter score: ");
            var num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            if (num <= 100)
            {
                bonusScore += 5;
            }

            else if (num > 100 && num <= 1000) 
            {
                bonusScore = num * 0.20;
            }

            else if (num > 1000)
            {
                bonusScore = num * 0.10;
            }

            if (num % 2 == 0)
            {
                bonusScore += 1;
            }

            if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine("Bonus score: " + bonusScore);
            Console.WriteLine("Total score: " + (num + bonusScore));
        }
    }
}
