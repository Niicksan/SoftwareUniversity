using System;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            string second = Console.ReadLine().TrimStart('0');

            int length = Math.Max(first.Length, second.Length);

            StringBuilder result = new StringBuilder(length + 1);
            int remainder = 0;

            first = first.PadLeft(length, '0');
            second = second.PadLeft(length, '0');

            // 231
            // 023
            for (int i = length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(first[i].ToString()); //1
                int num2 = int.Parse(second[i].ToString()); //3
                 
                int sum = num1 + num2 + remainder; //4

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
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}
