using System;

namespace _01._Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberType = Console.ReadLine();

            long minValue = 0;
            long maxValue = 0;

            switch (numberType)
            {
                case "sbyte":                  
                    minValue += -128;
                    maxValue += 127;
                    break;
                case "byte":
                    maxValue += 255;
                    break;
                case "int":
                    minValue += -2147483648;
                    maxValue += 2147483647;
                    break;
                case "uint":
                    maxValue += 4294967295;
                    break;
                case "long":
                    minValue += -9223372036854775808;
                    maxValue += 9223372036854775807;
                    break;
                default:
                    break;
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
    }
}
