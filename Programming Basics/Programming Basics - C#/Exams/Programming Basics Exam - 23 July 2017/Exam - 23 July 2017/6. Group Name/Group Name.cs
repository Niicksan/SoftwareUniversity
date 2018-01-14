using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine().ToUpper());
            char secondLetter = char.Parse(Console.ReadLine().ToLower());
            char thirdletter = char.Parse(Console.ReadLine().ToLower());
            char forthLEtter = char.Parse(Console.ReadLine().ToLower());
            int digit = int.Parse(Console.ReadLine());

            int counter = 0;
            for (char a = 'A'; a <= firstLetter; a++)
            {
                for (char b = 'a'; b <= secondLetter; b++)
                {
                    for (char c = 'a'; c <= thirdletter; c++)
                    {
                        for (char d = 'a'; d <= forthLEtter; d++)
                        {
                            for (int dig = 0; dig <= digit; dig++)
                            {
                                /*if (a == firstLetter && b == secondLetter && c == thirdletter
                                         && d == forthLEtter && dig == digit)
                                {
                                    break;
                                }*/
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter - 1);
        }
    }
}
