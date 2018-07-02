using System;

namespace _02._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}
