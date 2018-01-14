using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum = sum + num;
            }

            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("diff =" + Math.Abs(max - sum));
            }
        }
    }
}
