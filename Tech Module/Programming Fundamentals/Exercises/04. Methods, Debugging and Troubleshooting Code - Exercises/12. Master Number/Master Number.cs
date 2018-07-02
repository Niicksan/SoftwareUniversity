using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && IsDivide(i) && IsEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int n)
        {
            bool isPalindrome = true;
            string valueAsStr = n.ToString();

            for (int i = 0; i < valueAsStr.Length /2; i++)
            {
                if (valueAsStr[i] != valueAsStr[valueAsStr.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        static bool IsDivide(int n)
        {
            bool isDivide = false;
            int lastDigit = 0;
            int sum = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                sum += lastDigit;
                n /= 10;
            }

            if (sum % 7 == 0)
            {
                isDivide = true;
            }

            return isDivide;
        }

        static bool IsEven(int n)
        {
            bool isEven = false;
            int lastDigit = 0;

            while (n > 0)
            {
                lastDigit = n % 10;
                n /= 10;

                if (lastDigit % 2 == 0)
                {
                    isEven = true;
                    break;
                }
            }

            return isEven;
        }
    }
}
