using System;

namespace _01._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double moneyForSabers = lightsaberPrice * (students + Math.Ceiling(students * 0.10));
            double moneyForRobes = robesPrice * students;
            double moneyForBelts = beltPrice * (students - Math.Floor(students / 6.0));

            double totalPrice = moneyForSabers + moneyForRobes + moneyForBelts;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - money):F2}lv more.");
            }
        }
    }
}
