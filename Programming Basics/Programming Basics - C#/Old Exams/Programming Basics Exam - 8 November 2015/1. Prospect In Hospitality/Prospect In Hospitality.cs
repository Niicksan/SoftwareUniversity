using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Prospect_In_Hospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            uint builders = uint.Parse(Console.ReadLine());
            uint receptionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint otherStaff = uint.Parse(Console.ReadLine());
            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal dollarRate = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal staffSalary = (builders * 1500.04m) + (receptionists * 2102.10m) + (chambermaids * 1465.46m) +
                                  (technicians * 2053.33m);
            decimal ottherSalary = (otherStaff * 3010.98m) + (nikiSalary * dollarRate) + mySalary;
            decimal totalSalary = staffSalary + ottherSalary;
            decimal diff = Math.Abs(budget - totalSalary);

            Console.WriteLine($"The amount is: {totalSalary:f2} lv.");
            if (budget >= totalSalary)
            {
                Console.WriteLine($"YES \\ Left: {diff:f2} lv.");
            }
            else
            {
                Console.WriteLine($"NO \\ Need more: {diff:f2} lv.");
            }
        }
    }
}
