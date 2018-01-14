using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
           // int rows = n;

            for (int row = 1; row <= n; row++)
            {
                int counter = 0;
                for (int col = row; col <= n; col++)
                {
                    counter++;
                    Console.Write(col + " ");
                }

                //int leftToPrint = n - counter;
                int num = n - 1;

                while (counter != n)
                {
                    Console.Write(num + " ");
                    counter++;
                    num--;
                }

                Console.WriteLine();
            }
        }
    }
}
