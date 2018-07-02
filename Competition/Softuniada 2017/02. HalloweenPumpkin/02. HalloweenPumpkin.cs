using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalloweenPumpkin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}_/_{0}", new string('.', n - 1));
                }
                else if (row == 2)
                {
                    Console.WriteLine("/{0}^,^{0}\\", new string('.', n - 2));
                }
                else if (row == n)
                {
                    Console.WriteLine("\\{0}\\_/{0}/", new string('.', n - 2));
                }
                else
                {
                    Console.WriteLine("|{0}|", new string('.', (2 * n) - 1));
                }
            }
        }
    }
}
