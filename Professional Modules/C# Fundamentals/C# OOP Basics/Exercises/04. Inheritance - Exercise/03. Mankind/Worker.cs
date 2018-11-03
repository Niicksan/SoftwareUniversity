using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workingHoursPerDay;

        public Worker(string fistName, string lastName, decimal weekSalary, decimal workingHoursPerDay) : base(fistName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }


        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkingHoursPerDay
        {
            get { return this.workingHoursPerDay; }
            private set
            {
                if (!(value >=1 && value <= 12))
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHoursPerDay = value;
            }
        }

        public string CalculateSalaryPerHour()
        {
            decimal moneyPerHour = this.weekSalary / (this.workingHoursPerDay * 5);
            return $"{moneyPerHour:f2}";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder
                .Append(base.ToString())
                .AppendLine($"Week Salary: {WeekSalary:F2}")
                .AppendLine($"Hours per day: {WorkingHoursPerDay:F2}")
                .Append($"Salary per hour: {CalculateSalaryPerHour()}");

            return stringBuilder.ToString();
        }
    }
}
