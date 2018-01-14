using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int Num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Num);
                Num = Num * 2;
            }

            {
                /* int value = 2;
                 for (int power = 0; power <= n; power++)
                     Console.WriteLine((long)Math.Pow(value, power));
             }*/

            }
        }
    }
}
