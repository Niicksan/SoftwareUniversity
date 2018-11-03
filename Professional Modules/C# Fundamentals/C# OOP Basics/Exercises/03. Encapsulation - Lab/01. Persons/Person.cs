using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LasttName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LasttName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{firstName} {LasttName} is {Age} years old.";
        }
    }
}
