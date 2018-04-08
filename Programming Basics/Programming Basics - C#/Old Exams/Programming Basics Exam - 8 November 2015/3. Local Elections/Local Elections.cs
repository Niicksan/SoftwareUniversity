using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Local_Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidateLists = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            string symbol = (Console.ReadLine());

            Console.WriteLine(new string('.', 13));
            for (int i = 1; i <= candidateLists; i++)
            {
                Console.WriteLine("...+-----+...");
                if (i == vote)
                {
                    if (symbol.ToLower() == "x")
                    {
                        Console.WriteLine("...|.\\./.|...");
                        Console.WriteLine("{0}.|..{1}..|...", i.ToString().PadLeft(2, '0'), symbol.ToUpper());
                        Console.WriteLine("...|./.\\.|...");
                    }
                    else if (symbol.ToLower() == "v")
                    {
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine("{0}.|.\\./.|...", i.ToString().PadLeft(2, '0'));
                        Console.WriteLine("...|..{0}..|...", symbol.ToUpper());
                    }
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0}.|.....|...", i.ToString().PadLeft(2, '0'));
                    Console.WriteLine("...|.....|...");
                }
                Console.WriteLine("...+-----+...");
                Console.WriteLine(new string('.', 13));
            }
        }
    }
}
