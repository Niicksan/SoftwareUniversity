using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write(new string('+', 1));
                    Console.Write(new string('-', n - 2));
                    Console.Write(new string('+', 1));
                }

                else
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('-', n - 2));
                    Console.Write(new string('|', 1));
                }
                Console.WriteLine();
            }
        }
    }
}
