using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string privateMessegePattern = @"(^\d+)\s<->\s([A-Za-z0-9]+)$";
            string broadcastPattern = @"(^\D+)\s<->\s([A-Za-z0-9]+)$";

            List<string> privateMesseges = new List<string>();
            List<string> broadcastMesseges = new List<string>();

            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                Match privateMessege = Regex.Match(input, privateMessegePattern);
                Match broadcast = Regex.Match(input, broadcastPattern);

                if (privateMessege.Success)
                {
                    string recipientCodeInput = string.Join("", privateMessege.Groups[1].Value.Reverse());

                    string message = privateMessege.Groups[2].Value;
                    privateMesseges.Add(recipientCodeInput + " -> " + message);
                }
                if (broadcast.Success)
                {
                    string frequancyInput = broadcast.Groups[2].Value;
                    string frequancy = "";

                    for (int i = 0; i < frequancyInput.Length; i++)
                    {
                        if (char.IsUpper(frequancyInput[i]))
                        {
                            frequancy += frequancyInput[i].ToString().ToLower();
                        }
                        else
                        {
                            frequancy += frequancyInput[i].ToString().ToUpper();
                        }
                    }

                    string message = broadcast.Groups[1].Value;

                    broadcastMesseges.Add(frequancy + " -> " + message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            Console.WriteLine(broadcastMesseges.Count > 0 ?
                string.Join("\n", broadcastMesseges) : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(privateMesseges.Count > 0 ?
               string.Join("\n", privateMesseges) : "None");
        }
    }
}
