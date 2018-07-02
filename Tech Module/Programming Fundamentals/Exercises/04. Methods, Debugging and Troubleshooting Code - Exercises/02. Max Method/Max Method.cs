using System;

namespace _02._Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double maxNumber = GetMax(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(maxNumber);
        }

        static double GetMax(double firstNumber, double secondNumber, double thirdNumber)
        {
            double max = 0;

            if (firstNumber > secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }

            if (max < thirdNumber)
            {
                max = thirdNumber;
            }

            return max;
        }
    }
}
