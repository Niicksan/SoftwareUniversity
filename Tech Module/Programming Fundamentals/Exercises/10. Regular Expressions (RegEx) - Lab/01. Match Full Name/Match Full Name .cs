using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattertn = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattertn);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
