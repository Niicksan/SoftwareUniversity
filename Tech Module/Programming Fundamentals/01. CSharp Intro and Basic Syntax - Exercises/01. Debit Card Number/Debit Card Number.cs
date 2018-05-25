using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourtNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourtNum:D4} ");
        }
    }
}
