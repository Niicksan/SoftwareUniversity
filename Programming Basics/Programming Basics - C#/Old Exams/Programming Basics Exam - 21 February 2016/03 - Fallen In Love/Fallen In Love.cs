using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Fallen_In_Love
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sign = 0;
            int firstDots = 2 * n;
            int middleDots = 0;
            int secondDots = 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write("#");
                Console.Write(new string('~', sign));
                Console.Write("#");
                Console.Write(new string('.', firstDots));
                Console.Write("#");
                Console.Write(new string('.', middleDots));
                Console.Write("#");
                Console.Write(new string('.', firstDots));
                Console.Write("#");
                Console.Write(new string('~', sign));
                Console.WriteLine("#");
                sign++;
                firstDots -= 2;
                middleDots += 2;
            }

            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string('.', secondDots));
                Console.Write("#");
                Console.Write(new string('~', sign));
                Console.Write("#");
                Console.Write(new string('.', middleDots));
                Console.Write("#");
                Console.Write(new string('~', sign));
                Console.Write("#");
                Console.WriteLine(new string('.', secondDots));
                secondDots += 2;
                sign--;
                middleDots -= 2;
            }
            secondDots--;
            for (int row = 1; row <=n + 1 ; row++)
            {
                Console.Write(new string('.', secondDots));
                Console.Write(new string('#', 2));
                Console.WriteLine(new string('.', secondDots));
            }
        }
    }
}
