using System;
using System.Linq;

namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //string[] tokens = input.Split('|').ToArray();

            if (input.Contains("$AOTP$"))
            {
                Console.WriteLine("Argo");
                Console.WriteLine("Or");
                Console.WriteLine("The");
                Console.WriteLine("Parahaos");
            }
            else if (input.Contains("#POAML#|"))
            {
                Console.WriteLine("Post");
                Console.WriteLine("Office");
                Console.WriteLine("Ankh-Morpork");
                Console.WriteLine("Mister");
                Console.WriteLine("Lipwig");
            }
        }
    }
}
