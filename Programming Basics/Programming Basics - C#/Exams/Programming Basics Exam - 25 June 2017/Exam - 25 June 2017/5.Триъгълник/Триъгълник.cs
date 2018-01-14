using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Триъгълник
{
    class Триъгълник
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDots = 1;
            int hashtag = (2 * n - 1);
            int centralSpaces = 1;
            int newHashtag = (2 * n - 1);

            Console.WriteLine(new string('#', 4 * n + 1));
            for (int row = 1; row <= n; row++)
            {
                if (row != n / 2 + 1)
                {
                    Console.Write(new string('.', firstDots));
                    Console.Write(new string('#', hashtag));
                    Console.Write(new string(' ', centralSpaces));
                    Console.Write(new string('#', hashtag));
                    Console.WriteLine(new string('.', firstDots));
                    firstDots++;
                    hashtag -= 2;
                    centralSpaces += 2;
                }

                else
                {
                    int leftCentralSpace = (((4 * n + 1) - (2 * firstDots + 2 * hashtag)) - 3) / 2;

                    Console.Write(new string('.', firstDots));
                    Console.Write(new string('#', hashtag));
                    Console.Write(new string(' ', leftCentralSpace));
                    Console.Write("(@)");
                    Console.Write(new string(' ', leftCentralSpace));
                    Console.Write(new string('#', hashtag));
                    Console.WriteLine(new string('.', firstDots));
                    firstDots++;
                    hashtag -= 2;
                    centralSpaces += 2;
                }
            }

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', firstDots));
                Console.Write(new string('#', newHashtag));
                Console.WriteLine(new string('.', firstDots));
                firstDots++;
                newHashtag -= 2;
            }
        }
    }
}
