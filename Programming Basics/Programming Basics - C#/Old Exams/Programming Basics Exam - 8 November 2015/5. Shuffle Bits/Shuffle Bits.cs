using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Shuffle_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number1 = uint.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number1, 2).PadLeft(32, '0'));
            uint number2 = uint.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number2, 2).PadLeft(32, '0'));

            ulong result = 0;

            if (number1 >= number2)
            {

                for (int i = 31; i >= 0; i--)
                {
                    result = (result << 1) | ((number1 >> i) & 1);
                    result = (result << 1) | ((number2 >> i) & 1);
                }
            }

            else
            {
                for (int i = 31; i >= 0; i -= 2)
                {
                    result = (result << 1) | ((number1 >> i) & 1);
                    result = (result << 1) | ((number1 >> i - 1) & 1);
                    result = (result << 1) | ((number2 >> i) & 1);
                    result = (result << 1) | ((number2 >> i - 1) & 1);
                }
            }

            Console.WriteLine(result);
        }
    }
}
