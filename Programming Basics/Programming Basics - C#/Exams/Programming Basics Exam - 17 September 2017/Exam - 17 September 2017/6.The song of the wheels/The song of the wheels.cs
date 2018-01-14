using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            string password = null;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d < 9; d++)
                        {
                            if (n == a * b + c * d)
                            {
                                if (a < b && c > d)
                                {
                                    Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                                    counter++;

                                    if (counter == 4)
                                    {
                                        password = $"{a}{b}{c}{d}";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            if (password != null)
            {
                Console.WriteLine("Password: {0}", password);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
