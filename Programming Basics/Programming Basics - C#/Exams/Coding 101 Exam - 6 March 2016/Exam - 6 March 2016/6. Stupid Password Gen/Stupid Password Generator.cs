﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stupid_Password_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            int magic = int.Parse(Console.ReadLine());

            for (int num1 = 0; num1 <= 9; num1++)
            {
                for (int num2 = 0; num2 <= 9; num2++)
                {
                    for (int num3 = 0; num3 <= 9; num3++)
                    {
                        for (int num4 = 0; num4 <= 9; num4++)
                        {
                            for (int num5 = 0; num5 <= 9; num5++)
                            {
                                for (int num6 = 0; num6 <= 9; num6++)
                                {
                                    if (num1 * num2 * num3 * num4 * num5 * num6 == magic)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5}", num1, num2, num3, num4, num5, num6);
                                        Console.Write(" ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();




            /*   int n = int.Parse(Console.ReadLine());

               int n1 = 0;
               int n2;
               int n3;
               int n4;
               int n5;
               int n6;

               while (n1 <= 9)
               {
                   n2 = 0;
                   while (n2 <= 9)
                   {
                       n3 = 0;
                       while (n3 <= 9)
                       {
                           n4 = 0;
                           while (n4 <= 9)
                           {
                               n5 = 0;
                               while (n5 <= 9)
                               {
                                   n6 = 0;
                                   while (n6 <= 9)
                                   {
                                       if (n1 * n2 * n3 * n4 * n5 * n6 == n)
                                       {
                                           Console.Write("{0}{1}{2}{3}{4}{5}", n1, n2, n3, n4, n5, n6);
                                           Console.Write(" ");
                                       }
                                       n6++;
                                   }
                                   n5++;
                               }
                               n4++;
                           }
                           n3++;
                       }
                       n2++;
                   }
                   n1++;
               }
               Console.WriteLine();*/
        }
    }
}