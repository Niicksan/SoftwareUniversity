using System;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstMaterialsPrice = long.Parse(Console.ReadLine());
            long secondMaterialsPrice = long.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (firstMaterialsPrice >= sbyte.MinValue && firstMaterialsPrice <= sbyte.MaxValue)
            {
                totalPrice += firstMaterialsPrice * 4;
            }
            else
            {
                totalPrice += firstMaterialsPrice * 10;
            }

            if (secondMaterialsPrice >= sbyte.MinValue && secondMaterialsPrice <= sbyte.MaxValue)
            {
                totalPrice += secondMaterialsPrice * 4;
            }
            else
            {
                totalPrice += secondMaterialsPrice * 10;
            }

            Console.WriteLine(totalPrice);
        }
    }
}
