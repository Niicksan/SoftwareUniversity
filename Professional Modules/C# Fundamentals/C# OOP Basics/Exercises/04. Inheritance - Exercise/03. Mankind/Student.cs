using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string fistName, string lastName, string facultyNumber) : base(fistName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set
            {
                string pattern = @"^[a-zA-Z0-9]{5,10}$";

                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder
                .Append(base.ToString())
                .AppendLine($"Faculty number: {FacultyNumber}");

            return stringBuilder.ToString();
        }
    }
}
