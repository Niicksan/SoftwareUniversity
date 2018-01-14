using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool hasToEnd = false;
            for (int i = 1; i <= 3; i++)
            {
                if (hasToEnd == false)
                {
                    for (int j = 3; j >= 1; j--)
                    {
                        if (i + j == 2)
                        {
                            hasToEnd = true;
                            break;
                        }
                        Console.WriteLine(i + " " + j);
                    }
                }
            }*/


            /*int n = int.Parse(Console.ReadLine());
            int row = 1;

            int Num = 1;
            while(Num <= n)
            {
                for (int col = 1; col < row; col ++)
                {
                    if (Num == n)
                    {
                        break;
                    }
                    Console.Write(Num + " ");
                    Num++;
                }
                Console.WriteLine(Num);
                Num++;
                row++;
            } */

            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = row + col + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
