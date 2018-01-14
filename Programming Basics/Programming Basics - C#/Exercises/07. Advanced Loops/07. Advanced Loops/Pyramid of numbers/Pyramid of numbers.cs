using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;

            int num = 1;
            while (num <= n)
            {
                for (int i = 1; i < row;  i++)
                {
                    if (num == n)
                    {
                        break;
                    }

                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine(num);
                num++;
                row++;
            }
        }
    }
}
