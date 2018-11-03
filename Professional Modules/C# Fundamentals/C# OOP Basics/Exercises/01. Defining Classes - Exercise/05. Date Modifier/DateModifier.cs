using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        public static int GetDateDefference(string firstDate, string secondDate)
        {
            TimeSpan difference = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);
            return Math.Abs(difference.Days);
        }
    }
}
