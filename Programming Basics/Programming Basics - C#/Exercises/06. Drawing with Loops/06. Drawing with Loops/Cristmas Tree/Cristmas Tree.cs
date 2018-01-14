using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cristmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int intervals = n ;
            int stars = 0;

            for (int row = 1; row <= n+1; row ++)
            {
                Console.Write(new string(' ', intervals));
                Console.Write(new String('*', stars));
                Console.Write(" | ");
                Console.Write(new String('*', stars));
                Console.WriteLine(new string(' ', intervals));

                intervals--;
                stars++;
            }

            

        }
    }
}
