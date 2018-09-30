using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentAndGrade = Console.ReadLine().Split();

                string student = studentAndGrade[0];
                double grade = double.Parse(studentAndGrade[1]);

                if (!grades.ContainsKey(student))
                {
                    grades.Add(student, new List<double>());
                }

                grades[student].Add(grade);
            }

            foreach (var student in grades)
            {
                string name = student.Key;
                List<double> studentGrades = student.Value;
                double average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
