using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());
            double minPay = double.Parse(Console.ReadLine());

            double schoolership = 0;
            double socialSchoolership = 0;
            if (mark > 4.50 && mark < 5.50)
            {
                if (income < minPay)
                {
                    socialSchoolership = minPay * 0.35;
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialSchoolership));
                }

                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }

            else if (mark >= 5.50)
            {
                schoolership = mark * 25;
                if (income < minPay)
                {
                    socialSchoolership = minPay * 0.35;
                }

                if (socialSchoolership > schoolership)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Ceiling(socialSchoolership));
                }

                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(schoolership));
                }
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
