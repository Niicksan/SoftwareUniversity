using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    int max = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstLetter = char.Parse(Console.ReadLine());
                    char secondLetter = char.Parse(Console.ReadLine());
                    char maxi = GetMax(firstLetter, secondLetter);
                    Console.WriteLine(maxi);
                    break;
                case "string":
                    string firstName = Console.ReadLine();
                    string secondname = Console.ReadLine();
                    string maxxi = GetMax(firstName, secondname);
                    Console.WriteLine(maxxi);
                    break;
            }

        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }

            return second;
        }
    }
}
