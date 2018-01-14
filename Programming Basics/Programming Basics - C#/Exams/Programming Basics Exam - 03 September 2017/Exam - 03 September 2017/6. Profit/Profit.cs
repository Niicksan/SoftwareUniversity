using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int oneBanknotes = int.Parse(Console.ReadLine());
            int twoBanknotes = int.Parse(Console.ReadLine());
            int fiveBanknotes = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int cntOne = 0; cntOne <= oneBanknotes; cntOne++)
            {
                for (int cntTwo = 0; cntTwo <= twoBanknotes; cntTwo++)
                {
                    for (int cntFive = 0; cntFive <= fiveBanknotes; cntFive++)
                    {
                        if ((cntOne * 1) + (cntTwo * 2) + (cntFive * 5) == sum)
                        {
                            Console.WriteLine($"{cntOne} * 1 lv. + {cntTwo} * 2 lv. + {cntFive} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
