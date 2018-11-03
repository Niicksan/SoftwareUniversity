using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get { return this.name;  }
        }

        public int Age
        {
            get { return this.age; }
        }

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age) : this()
        {
            this.age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.name = name;
            this.age = age;
        }
    }
}