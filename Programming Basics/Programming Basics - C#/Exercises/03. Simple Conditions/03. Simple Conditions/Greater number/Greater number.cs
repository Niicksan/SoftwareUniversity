using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Integers: ");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Greater number is: " + num1);
            }

            else
	        {
                Console.WriteLine("Greater number is: " + num2);
            } 
        }
    }
}
