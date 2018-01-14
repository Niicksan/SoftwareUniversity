using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_n_x_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <=n; row++)
            {
                for (int col = 1; col <= 2 * n - 1; col++)
                {
                    if (col %2 == 0)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
