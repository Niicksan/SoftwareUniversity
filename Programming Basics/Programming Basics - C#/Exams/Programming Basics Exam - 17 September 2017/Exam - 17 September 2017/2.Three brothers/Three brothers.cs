using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double totalTime = double.Parse(Console.ReadLine());

            double time = (1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother)) + ((1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother)) * 0.15);
            double timeLeft = (totalTime - time);

            Console.WriteLine("Cleaning time: {0:f2}", time);
            if (timeLeft > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeLeft));
            }

            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(time - totalTime));
            }
        }
    }
}
