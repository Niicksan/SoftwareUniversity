using System;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string digit = NameToString(number);
            Console.WriteLine(digit);
        }

        private static string NameToString(long number)
        {
            long lastDigit = number % 10;
            string digit = "";

            switch (lastDigit)
            {
                case 1:
                    digit += "one";
                    break;
                case 2:
                    digit += "two";
                    break;
                case 3:
                    digit += "three";
                    break;
                case 4:
                    digit += "four";
                    break;
                case 5:
                    digit += "five";
                    break;
                case 6:
                    digit += "six";
                    break;
                case 7:
                    digit += "seven";
                    break;
                case 8:
                    digit += "eight";
                    break;
                case 9:
                    digit += "nine";
                    break;
                case 0:
                    digit += "zero";
                    break;
            }

            return digit;
        }
    }
}
