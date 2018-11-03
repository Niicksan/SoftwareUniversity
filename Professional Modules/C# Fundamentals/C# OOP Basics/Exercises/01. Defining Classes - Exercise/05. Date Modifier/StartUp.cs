using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            
            int days = DateModifier.GetDateDefference(firstDate, secondDate);

            Console.WriteLine(days);
        }
    }
}