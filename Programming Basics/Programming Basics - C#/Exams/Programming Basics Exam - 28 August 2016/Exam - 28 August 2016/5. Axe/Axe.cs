using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDashes = 3 * n;
            int centralDashes = 0;
            int lastDashes = (5 * n) - ((firstDashes + centralDashes) + 2);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write("*");
                Console.Write(new string('-', centralDashes));
                Console.Write("*");
                Console.WriteLine(new string('-', lastDashes));
                centralDashes++;
                lastDashes--;
            }

            int dashes = n - 1;
            int LastDashes = (5 * n) - ((firstDashes + dashes) + 2);

            for (int row2 = 1; row2 <= n / 2; row2++)
            {
                Console.Write(new string('*', firstDashes));
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.WriteLine(new string('-', LastDashes));
            }

            for (int row3 = 1; row3 < (n / 2); row3++)
            {
                Console.Write(new string('-', firstDashes));
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.WriteLine(new string('-', LastDashes));
                firstDashes--;
                dashes += 2;
                LastDashes--;
            }

            Console.Write(new string('-', firstDashes));
            Console.Write("*");
            Console.Write(new string('*', dashes));
            Console.Write("*");
            Console.WriteLine(new string('-', LastDashes));
        }
    }
}
