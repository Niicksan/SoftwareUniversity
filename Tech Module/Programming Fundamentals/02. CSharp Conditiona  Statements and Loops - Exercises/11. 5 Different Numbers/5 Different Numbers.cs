using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    for (int num3 = start; num3 <= end; num3++)
                    {
                        for (int num4 = start; num4 <= end; num4++)
                        {
                            for (int num5 = start; num5 <= end; num5++)
                            {
                                if (start <= num1 && num1 < num2 && num2 < num3 && num3 < num4 && num4 < num5 && num5 <= end)
                                {

                                    Console.WriteLine($"{num1} {num2} {num3} {num4} {num5}");
                                    counter++;

                                }
                            }
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
