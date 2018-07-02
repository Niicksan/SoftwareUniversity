using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = Console.ReadLine();

            Dictionary<string, string> emails = new Dictionary<string, string>();

            int count = 1;
            string name = "";

            while (mail != "stop")
            {
                if (count % 2 == 1)
                {
                    name = mail;
                }
                else if (count % 2 == 0)
                {
                    if (mail.Contains(".us") || mail.Contains(".uk"))
                    {
                        break;
                    }
                    emails.Add(name, mail);
                    name = "";
                }

                count++;
                mail = Console.ReadLine();
            }

            foreach (var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
