﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int poor = 0;
            int satisfactory = 0;
            int good = 0;
            int verygood = 0;
            int exellence = 0;

            for (int grade = 1; grade <= n; grade++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points < 22.5)
                {
                    poor++;
                }

                else if (points >= 22.5 && points < 40.5)
                {
                    satisfactory++;
                }
                else if (points >= 40.5 && points < 58.5)
                {
                    good++;
                }
                else if (points >= 58.5 && points < 76.5)
                {
                    verygood++;
                }
                else if (points >= 76.5 && points <= 100)
                {
                    exellence++;
                }
            }

            double Poor = (poor * 100.0) / n;
            double Satisfactory = (satisfactory * 100.0) / n;
            double Good = (good * 100.0) / n;
            double Verygood = (verygood * 100.0) / n;
            double Exellence = (exellence * 100.0) / n;

            Console.WriteLine("{0:f2}% poor marks", Poor);
            Console.WriteLine("{0:f2}% satisfactory marks", Satisfactory);
            Console.WriteLine("{0:f2}% good marks", Good);
            Console.WriteLine("{0:f2}% very good marks", Verygood);
            Console.WriteLine("{0:f2}% excellent marks", Exellence);
        }
    }
}
