using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int One = int.Parse(Console.ReadLine());
            int Two = int.Parse(Console.ReadLine());
            int Five = int.Parse(Console.ReadLine());
            int summ = int.Parse(Console.ReadLine());

            for (int one = 0; one <= One; one++)
            {
                for (int two = 0; two <= Two; two++)
                {
                    for (int five = 0; five <= Five; five++)
                    {
                        if ((one * 1) + (two * 2) + (five * 5) == summ)
                        {
                            Console.WriteLine("{0}{1}{2}{3}", one, two, five, summ);
                        }
                    }
                }
            }
        }
    }
}
