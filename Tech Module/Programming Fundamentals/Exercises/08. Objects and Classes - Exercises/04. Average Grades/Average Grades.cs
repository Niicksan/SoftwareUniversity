using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] tokens = line.Split();
                string name = tokens[0];

                double[] grades = tokens
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                Student student = new Student(name, grades);
                student.Add(student);

                student.Where(s => s.Grades);>


           }*/


            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            List<double> gradess = new List<double>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] tokens = line.Split();
                string name = tokens[0];

                double[] grades = tokens
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                double sum = 0;
                for (int j = 0; j < grades.Length - 1; j++)
                {
                    sum += grades[j];
                    sum /= grades.Length;
                }

                names.Add(name);
                gradess.Add(sum);
                sum = 0;
            }

            foreach (var item in names)
            {
                Console.Write(item + " -> ");
                foreach (var grade in gradess)
                {
                    Console.WriteLine($"{grade}");
                }
            }
        }
    }
}

class Student
{
    public Student(string name, double grades)
    {
        Name = name;
        this.Grades = grades;
    }

    public string Name { get; set; }
    public double Grades { get; set; }

    internal void Where(Func<object, object> p)
    {
        throw new NotImplementedException();
    }
}
