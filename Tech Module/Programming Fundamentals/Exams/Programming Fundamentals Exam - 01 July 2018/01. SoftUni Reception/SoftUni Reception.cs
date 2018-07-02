using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmploye = int.Parse(Console.ReadLine());
            int secondEmploye = int.Parse(Console.ReadLine());
            int thirdEmploye = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = firstEmploye + secondEmploye + thirdEmploye;

            int time = 0;
            int count = 0;
            while (students > 0)
            {
                time += 1;

                count++;
                if (count == 3)
                {
                    time += 1;
                    count = 0;
                }

                students -= studentsPerHour;
            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
