using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Сбор_или_Произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool found = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a < b && b < c)
                        {
                            if (a + b + c == n)
                            {
                                found = true;
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                            }
                        }

                        else if (a > b && b > c)
                        {
                            if (a * b * c == n)
                            {
                                found = true;
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                            }
                        }
                    }
                }
            }

            if (found == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
