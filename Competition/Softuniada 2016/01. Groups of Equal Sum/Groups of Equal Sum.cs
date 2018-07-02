using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Groups_of_Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4;

            if (num1 == (num2 + num3 + num4) || (num1 + num2) == (num3 + num4) || (num1 + num3) == (num2 + num4)
                     || (num1 + num2 + num3) == num4 || (num1 + num2 + num4) == num3 
                     || (num1 + num3 + num4) == num2 || (num1 + num4) == (num2 + num3))
            {
                Console.WriteLine("Yes");
                Console.WriteLine(sum / 2);
            }
  
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
