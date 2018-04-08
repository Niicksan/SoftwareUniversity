using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDots = n;
            int secondDots = 0;
            int middleDots = n - 2;

            for (int row  = 1; row  <= n / 2+ 1; row ++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
                    firstDots -= 2;
                }
                else
                {
                    Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', firstDots), new string('.', secondDots), new string('.', middleDots));
                    firstDots -= 2;
                    secondDots += 2;
                }
            }
            firstDots += 2;
            secondDots -= 2;
            for (int row = 1; row <= n / 2 + 1; row++)
            {
                if (row != n / 2 + 1)
                {
                    Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', firstDots), new string('.', secondDots), new string('.', middleDots));
                    firstDots += 2;
                    secondDots -= 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
                }
            }
        }
    }
}
