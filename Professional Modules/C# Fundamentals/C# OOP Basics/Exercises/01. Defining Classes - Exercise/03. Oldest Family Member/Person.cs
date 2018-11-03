﻿namespace DefiningClasses
{
    public class Person
    {
        public string name;
        public int age;


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }
    }
}