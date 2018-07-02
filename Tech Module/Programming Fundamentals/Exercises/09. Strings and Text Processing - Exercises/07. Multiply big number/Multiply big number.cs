using System;
using System.Linq;
using System.Text;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            string multiplier = Console.ReadLine();

            StringBuilder result = new StringBuilder(number.Length + 1);
            int remainder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(number[i].ToString()); 
                int num2 = int.Parse(multiplier); 

                int sum = num1 * num2 + remainder; 

                int lastDig = sum % 10;
                result.Append(lastDig);

                remainder = sum / 10;
            }

            if (remainder > 0)
            {
                result.Append(remainder);
            }
            
            for (int i = result.Length - 1; i >= 0; i--)
            {
                string str = "";
                str += result[i];
                bool containsDups = str.Length == str.Distinct().Count();
                if (containsDups && int.Parse(multiplier) == 0)
                {
                    Console.WriteLine("0");
                    break;
                }
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}
