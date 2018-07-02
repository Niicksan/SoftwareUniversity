using System;
using System.Text.RegularExpressions;

namespace _03._Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string snowflake = string.Empty;

            string surfacePattern = @"^[^A-Za-z0-9]+$";
            string mantlePattern = @"^[0-9_]+$";
            string multiPattern = @"^([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";

            bool isAllFine = true;
            int coreLength = 0;
            for (int index = 1; index <= 5; index++)
            {
                snowflake = Console.ReadLine();

                string currentPattern = string.Empty;

                if (index == 1 || index == 5)
                {
                    currentPattern = surfacePattern;
                }
                else if (index == 2 || index == 4)
                {
                    currentPattern = mantlePattern;
                }
                else
                {
                    currentPattern = multiPattern;
                }

                Regex regex = new Regex(currentPattern);
                
                if (regex.IsMatch(snowflake) && index == 3)
                {
                    coreLength = regex.Match(snowflake).Groups["core"].Value.Length;
                }

                if (!regex.IsMatch(snowflake))
                {
                    isAllFine = false;
                }
            }

            if (isAllFine)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
