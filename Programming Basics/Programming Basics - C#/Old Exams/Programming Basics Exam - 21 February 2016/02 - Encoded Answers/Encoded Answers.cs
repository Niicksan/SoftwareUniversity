using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            string answers = "";

            uint countA = 0;
            uint countB = 0;
            uint countC = 0;
            uint countD = 0;

            for (int i = 1; i <= n; i++)
            {
                uint number = uint.Parse(Console.ReadLine());

                if (number % 4 == 0)
                {
                    answers += "a ";
                    countA++;
                }
                else if (number % 4 == 1)
                {
                    answers += "b ";
                    countB++;
                }
                else if (number % 4 == 2)
                {
                    answers += "c ";
                    countC++;
                }
                else if (number % 4 == 3)
                {
                    answers += "d ";
                    countD++;
                }
            }

            Console.WriteLine(answers);
            Console.WriteLine($"Answer A: {countA}");
            Console.WriteLine($"Answer B: {countB}");
            Console.WriteLine($"Answer C: {countC}");
            Console.WriteLine($"Answer D: {countD}");
        }
    }
}
