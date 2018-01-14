using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopByStep3
{
    class LoopByStep3
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbes are:");

            for (int i = 1; i <= n; i+= 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
