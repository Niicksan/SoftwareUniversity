using System;

namespace _04._Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double maxCapacity = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)people / maxCapacity);

            Console.WriteLine(courses);
        }
    }
}
