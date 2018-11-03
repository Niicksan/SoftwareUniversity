using System;

namespace Mankind
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                string studentFirstName = studentInfo[0];
                string studentLasttName = studentInfo[1];
                string facultyNumber = studentInfo[2];

                Student student = new Student(studentFirstName, studentLasttName, facultyNumber);

                string workerFirstName = workerInfo[0];
                string workerLasttName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                decimal workingHourPerDay = decimal.Parse(workerInfo[3]);

                Worker worker = new Worker(workerFirstName, workerLasttName, weekSalary, workingHourPerDay);

                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
