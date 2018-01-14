using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb
{
    class Romb
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int intervals = n - 1;
            int stars = 1;
            int cols = 1;
            
            for (int row = 1; row <= n; row++)
            {
                //Начални интервали
                Console.Write(new string(' ', intervals));

                //Междинни колони
                for (int col = 1; col <= cols; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                //Крайни интервали
                Console.WriteLine(new string(' ', intervals));
                intervals --;
                cols += 2;
            }

            intervals = 1;
            cols = 2 * n - 3;
            for (int row = 1; row <= 2 * n - 1; row++)
            {
                //Начални интервали
                Console.Write(new string(' ', intervals));

                //Междинни колони
                for (int col = 1; col <= cols; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                //Крайни интервали
                Console.WriteLine(new string(' ', intervals));
                intervals++;
                cols -= 2;
            }
        }
    }
}
