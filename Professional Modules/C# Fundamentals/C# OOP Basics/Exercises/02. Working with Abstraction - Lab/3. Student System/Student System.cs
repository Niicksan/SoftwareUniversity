using System;
using System.Collections.Generic;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            string input = Console.ReadLine();

            while (input != "Exit")
            {
                string[] studentInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string operation = studentInfo[0];

                if (operation == "Create")
                {
                    CreateStudent(students, studentInfo);
                }
                else if (operation == "Show")
                {
                    ShowStudent(students, studentInfo);
                }

                input = Console.ReadLine();
            }
        }

        private static void ShowStudent(Dictionary<string, Student> students, string[] studentInfo)
        {
            string name = studentInfo[1];

            if (students.ContainsKey(name))
            {
                Student student = students[name];
                Console.WriteLine(student);
            }
        }

        private static void CreateStudent(Dictionary<string, Student> students, string[] studentInfo)
        {
            string name = studentInfo[1];

            if (!students.ContainsKey(name))
            {
                int age = int.Parse(studentInfo[2]);
                double grade = double.Parse(studentInfo[3]);

                Student student = new Student(name, age, grade);
                students.Add(name, student);
            }
        }
    }
}
