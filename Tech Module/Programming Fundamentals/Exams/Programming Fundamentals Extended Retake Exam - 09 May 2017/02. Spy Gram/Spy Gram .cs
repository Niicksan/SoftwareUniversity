using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _02._Spy_Gram_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programming Fundamentals Extended Retake Exam - 09 May 2017 Part I

            Regex pattern = new Regex(@"TO: ([A-Z]+); MESSAGE: (.*?);");

            string key = Console.ReadLine();
            string message = Console.ReadLine();

            SortedDictionary<string, string> encryptedMessages = new SortedDictionary<string, string>();
            while (message != "END")
            {
                Match match = pattern.Match(message);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string text = match.Value;

                    encryptedMessages.Add(name, text);
                }

                message = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();
            foreach (var recipient in encryptedMessages.Values)
            {
                string text = recipient;

                for (int i = 0; i < text.Length; i++)
                {
                    int numberAscii = text[i] + int.Parse(key[i % key.Length].ToString());

                    sb.Append((char)numberAscii);
                }

                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
