using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumTo13
{
    class SumTo13
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b + c == 13 ||
                -a + b - c == 13 ||
                a - b + c == 13 ||
                a + b - c == 13 ||
                -a -b + c == 13 ||
                a - b - c == 13 ||
                - a - b - c == 13
                )
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
