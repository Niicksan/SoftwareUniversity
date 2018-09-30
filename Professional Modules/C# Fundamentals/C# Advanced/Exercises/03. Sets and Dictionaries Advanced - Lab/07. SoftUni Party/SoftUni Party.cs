using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> vipNumbers = new HashSet<string>();
            HashSet<string> regularNumbers = new HashSet<string>();

            while (input != "PARTY")
            {
                bool isDig = int.TryParse(input[0].ToString(), out int result);

                if (isDig)
                {
                    vipNumbers.Add(input);
                }
                else
                {
                    regularNumbers.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (vipNumbers.Contains(input))
                {
                    vipNumbers.Remove(input);
                }
                else if (regularNumbers.Contains(input))
                {
                    regularNumbers.Remove(input);
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine(vipNumbers.Count + regularNumbers.Count);          

            foreach (var vipNumber in vipNumbers)
            {
                Console.WriteLine(vipNumber);
            }

            foreach (var regularNumber in regularNumbers)
            {
                Console.WriteLine(regularNumber);
            }
        }
    }
}
