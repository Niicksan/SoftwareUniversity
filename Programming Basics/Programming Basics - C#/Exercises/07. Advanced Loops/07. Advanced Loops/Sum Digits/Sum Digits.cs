using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            do
            {
                int dig = n % 10;
                sum += dig;
                n /= 10;
            }
            while (n > 0);
        
            Console.WriteLine(sum);
        }
    }
}
