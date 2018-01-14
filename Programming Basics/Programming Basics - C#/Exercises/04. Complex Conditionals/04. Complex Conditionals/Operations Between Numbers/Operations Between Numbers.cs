using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            string evenOdd;

            double result;

            if (oper == "+" || oper == "-" || oper == "*")
            {

                if (oper == "+")
                {
                    result = num1 + num2;
                }

                else if (oper == "-")
                {
                    result = num1 - num2;
                }

                else
                {
                    result = num1 * num2;

                }

                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }

                else
                {
                    evenOdd = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}, num1", oper, num2, result, evenOdd);
            }


            else if (oper == "/" || oper == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }

                else
                {
                    if (oper == "/")
                    {
                        result = (num1 * 1.0) / (num2 * 1.0);
                        Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, result);
                    }


                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine("{0} {1} {2} = {3:0}", num1, oper, num2, result);
                    }
                }
            }
    }
}
