using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Spy_Gram
{
    class Program
    {
        // Programming Fundamentals Extended Retake Exam - 09 May 2017 Part I

        class Recipient
        {
            public string Name { get; set; }

            public string Text { get; set; }

            public Recipient(string name, string text)
            {
                Name = name;
                Text = text;
            }
        }

        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"TO: ([A-Z]+); MESSAGE: (.*?);");

            List<Recipient> recipients = new List<Recipient>();

            string key = Console.ReadLine();
            string message = Console.ReadLine();

            while (message != "END")
            {
                Match match = pattern.Match(message);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string text = match.Value;

                    Recipient recipient = new Recipient(name, text);
                    recipients.Add(recipient);
                }

                message = Console.ReadLine();
            }

            recipients = recipients.OrderBy(x => x.Name).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var recipient in recipients)
            {
                string text = recipient.Text;

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
