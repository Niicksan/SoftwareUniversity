using System;
using System.Collections.Generic;

namespace _07._Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] tokens = line.Split('-');
                string tcreatorName = tokens[0];
                string teamName = tokens[1];

            }
        }
    }

    class Team
    {
        public Team(string teamName, string ownerName, List<string> myProperty)
        {
            TeamName = teamName;
            OwnerName = ownerName;
            MyProperty = myProperty;
        }

        public string TeamName { get; set; }

        public string OwnerName { get; set; }

        public List<string> new List<string>() { get; set; }
    }
}
