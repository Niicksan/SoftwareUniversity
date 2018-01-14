﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Java
{
    class Java
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = (3 * n) + 1;
            int col = (3 * n) + 6;
            int spaces = n;
            int tilde = (2 * n) + 4;
            int spacesLeft = (col - spaces) - 5;

            for (int row1 = 1; row1 <= n; row1++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("~");
                Console.Write(" ");
                Console.Write("~");
                Console.Write(" ");
                Console.Write("~");
                Console.WriteLine(new string(' ', spacesLeft));
            }

            for (int row2 = 1; row2 <= n; row2++)
            {
                if (row2 == 1 || row2 == n)
                {
                    Console.WriteLine(new string('=', col - 1));
                }

                else
                {
                    if (row2 == (n / 2) + 1)
                    {
                        Console.Write(("|"));
                        Console.Write(new string('~', n));
                        Console.Write("JAVA");
                        Console.Write(new string('~', n));
                        Console.Write(("|"));
                        Console.Write(new string(' ', spaces - 1));
                        Console.WriteLine("|");
                    }

                    else
                    {
                        Console.Write("|");
                        Console.Write(new string('~', tilde));
                        Console.Write("|");
                        Console.Write(new string(' ', spaces - 1));
                        Console.WriteLine("|");
                    }
                }
            }

            int leftSpaces = 0;
            int rightSpaces = n;
            int at = (2 * n) + 4;
            int equal = (2 * n) + 6;

            for (int row3 = 1; row3 <= n; row3++)
            {
                Console.Write(new string(' ', leftSpaces));
                Console.Write(@"\");
                Console.Write(new string('@', at));
                Console.Write("/");
                Console.WriteLine(new string(' ', rightSpaces));

                leftSpaces++;
                at -= 2;
                rightSpaces++;
            }
            Console.WriteLine(new string('=', equal));
        }
    }
}
