using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minArrival = int.Parse(Console.ReadLine());

            int timeExam = (hourExam * 60) + minExam;
            int timeArrival = (hourArrival * 60) + minArrival;

            int timeInterval = (timeExam - timeArrival);

            if (timeInterval >= 0 && timeInterval <= 30)
            {
                Console.WriteLine("On Time");
                if (timeInterval == 0)
                {
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("{0} minutes before the start", timeInterval);
                }
            }

            else if (timeInterval > 30)
            {
                Console.WriteLine("Early");
                if (timeInterval < 60)
                {
                    Console.WriteLine("{0} minutes before the start", timeInterval);
                }

                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", timeInterval / 60, timeInterval % 60);
                }
            }

            else
            {
                Console.WriteLine("late");
                timeInterval = -timeInterval;

                if (timeInterval < 60)
                {
                    Console.WriteLine("{0} minutes after the start", timeInterval);
                }

                else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", timeInterval / 60, timeInterval % 60);
                }
            }
        }
    }
}
