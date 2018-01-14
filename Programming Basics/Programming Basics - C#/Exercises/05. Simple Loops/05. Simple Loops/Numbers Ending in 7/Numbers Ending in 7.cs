using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 1000; n++)
            {
                if (n % 10 == 7)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
