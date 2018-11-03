using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                if (string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }


        public string Gender
        {
            get { return this.gender; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(this.GetType().Name)
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .AppendLine(this.ProduceSound());

            return builder.ToString();
        }
    }
}