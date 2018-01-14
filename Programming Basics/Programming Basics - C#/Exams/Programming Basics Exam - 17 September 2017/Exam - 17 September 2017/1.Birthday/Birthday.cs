using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double totalLiters = volume * 0.001;

            double realLiters = totalLiters - (totalLiters * (percentage / 100));

            Console.WriteLine("{0:f3}", realLiters);
        }
    }
}
