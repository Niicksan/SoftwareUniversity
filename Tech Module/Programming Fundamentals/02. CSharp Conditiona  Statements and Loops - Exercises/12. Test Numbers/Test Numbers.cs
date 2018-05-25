using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;
            for (int i = first; i >= 1; i--)
            {
                for (int m = 1; m <= second; m++)
                {
                    sum += 3 * (i * m);
                    count++;

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
