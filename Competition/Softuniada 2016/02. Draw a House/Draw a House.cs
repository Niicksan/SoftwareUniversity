using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Draw_a_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n - 1;
            int foofSpaces = 0;
            int minSpaces = (2 * n) - 3;

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.Write(new string('.', dots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dots));
                    dots--;
                    foofSpaces++; 
                }
                else if (row == n)
                {
                    for (int col = 1; col <= (2 * n) - 1; col++)
                    {
                        if (col % 2 == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('.', dots));
                    Console.Write("*");
                    Console.Write(new string(' ', foofSpaces));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dots));
                    dots--;
                    foofSpaces += 2;
                }
            }

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write("+");
                    Console.Write(new string('-', minSpaces));
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', minSpaces));
                    Console.WriteLine("|");
                }
            }
        }
    }
}
