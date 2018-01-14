using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spaces = 2 * n - 2; // двете колони минус двете |
            if (n < 5)
            {
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.Write(@"\");
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.WriteLine(@"\");

                for (int row = 1; row <= n - 2; row++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine("|");
                }

                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.Write("/");
                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.WriteLine("/");
            }

            else
            {
                //Underscore - долна черта =>
                /* 2 * n (колоните) - (n / 2) (един път комплект ^ ) 
                     - (n / 2) (втори път ^ ) + 4 (два пъти двете наклонени черти)
                */
                int underscore = 2 * n - (n / 2 + n / 2 + 4);
                //int spaces = 
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.Write(@"\");
                Console.Write(new string('_', underscore));
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.WriteLine(@"\");

                for (int row = 1; row <= n - 3; row++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine("|");
                }

                spaces = n / 2 + 1;
                Console.Write("|");
                Console.Write(new string(' ', spaces));
                Console.Write(new string('_', underscore));
                Console.Write(new string(' ', spaces));
                Console.WriteLine("|");

                spaces = underscore; //Броят интервали е равен на броя долни черти
                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.Write("/");
                Console.Write(new string(' ', spaces));
                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.WriteLine("/");
            }
        }
    }
}
