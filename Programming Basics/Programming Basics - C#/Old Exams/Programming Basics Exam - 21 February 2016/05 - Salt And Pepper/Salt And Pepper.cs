using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Salt_And_Pepper
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] comandElemnt = comand.Split(' ');
                string action = comandElemnt[0];
                int step = int.Parse(comandElemnt[1]);

                if (action == "salt")
                {
                    for (int i = 0; i <= 63; i += step)
                    {
                        if (((number >> i) & 1) == 1)
                        {
                            ulong mask = ~((ulong)1 << i);
                            number = number & mask;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= 63; i += step)
                    {
                        if (((number >> i) & 1) == 0)
                        {
                            ulong mask = ~(ulong)1 << i;
                            number = number | mask;
                        }
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(number);
        }
    }
}
