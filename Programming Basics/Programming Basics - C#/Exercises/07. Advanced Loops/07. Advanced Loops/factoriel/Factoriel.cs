using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoriel
{
    class Factoriel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            long result = 1;

            /*for (int i = n; i >= 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);*/

            while (i <= n)
            {
                result *= i;
                i++;   
            }
            Console.WriteLine(result);
        }
    }
}
