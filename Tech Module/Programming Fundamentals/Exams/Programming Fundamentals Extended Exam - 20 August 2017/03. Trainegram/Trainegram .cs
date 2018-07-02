using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Train_Gram
{
    class Program
    {
        static void Main(string[] args)
        { // Programming Fundamentals Extended Exam - 20 August 2017 Part II

            string input = Console.ReadLine();

            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*\]\.)*$"))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}

