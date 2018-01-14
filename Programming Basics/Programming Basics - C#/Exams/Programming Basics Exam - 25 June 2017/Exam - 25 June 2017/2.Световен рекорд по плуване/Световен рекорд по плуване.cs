using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double time = distance * seconds;
            double resist = 12.5 * Math.Floor(distance / 15);
            double totalTime = time + resist;

            if (totalTime < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", totalTime);
            }

            else
            {
                double diff = totalTime - record;
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", diff);
            }
        }
    }
}
