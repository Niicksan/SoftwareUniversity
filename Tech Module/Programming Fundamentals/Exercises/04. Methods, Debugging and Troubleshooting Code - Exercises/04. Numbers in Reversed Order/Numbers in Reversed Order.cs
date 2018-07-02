using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            string reversed = ReversedNumber(num);
            Console.WriteLine(reversed);
        }

        static string ReversedNumber(decimal num)
        {
            string number = num.ToString();
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number.Substring(number.Length - 1, 1);
                number = number.Remove(number.Length - 1);
            }

            return reversed;
        }
    }
}
