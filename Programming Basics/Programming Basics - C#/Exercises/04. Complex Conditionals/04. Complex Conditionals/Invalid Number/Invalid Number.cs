using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        //    var num = int.Parse(Console.ReadLine());

        //    if (num < 0 || (num > 0 && num < 100) || num > 200)
        //    {
        //        Console.WriteLine("ìnvalid");
        //    }

        //     else
        //    {
        //        Console.WriteLine("");
        //    }

            var num = int.Parse(Console.ReadLine());
            var inrange = (num >= 100 && num <= 200) || num == 0;

            if (!inrange)
            {
                Console.WriteLine("ìnvalid");
            }

            else
            {
                Console.WriteLine("");
            }
        }
    }
}
