using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Crypto_Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string sequence = "";

            string output = "";

            for (int i = 0; i < n; i++)
            {
                sequence += Console.ReadLine();
            }

            string pattern = @"{[^\]\[{]+}|\[[^{}\[]+\]";
            MatchCollection matches = Regex.Matches(sequence, pattern);

            List<string> valid = new List<string>();

            foreach (Match match in matches)
            {
                valid.Add(match.ToString());
            }

            for(int i = 0; i < valid.Count; i++)
            {
                string numbers = "";
                for (int j = 0; j < valid[i].Length; j++)
                {
                    if (char.IsDigit(valid[i][j]))
                    {
                        numbers += valid[i][j];
                    }
                }

                if (numbers.Length % 3 != 0)
                {
                    continue;
                }

                string numberPattern = @"[0-9]{3}";
                MatchCollection numMatches = Regex.Matches(valid[i], numberPattern);

                foreach (Match match in numMatches)
                {
                    int num = int.Parse(match.ToString());
                    num -= valid[i].Length;

                    char ch = (char)num;
                    output += ch;
                }
            }

            Console.WriteLine(output);
        }
    }
}