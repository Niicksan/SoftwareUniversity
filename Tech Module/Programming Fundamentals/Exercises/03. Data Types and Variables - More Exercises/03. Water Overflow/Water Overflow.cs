using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tankCapacity = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (tankCapacity + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankCapacity += liters;
                }
            }

            Console.WriteLine(tankCapacity);
        }
    }
}
