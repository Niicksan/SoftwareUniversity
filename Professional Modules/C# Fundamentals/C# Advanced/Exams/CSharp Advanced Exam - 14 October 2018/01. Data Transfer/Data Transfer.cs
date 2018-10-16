using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Data_Transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "s:([^;]+);r:([^;]+);m--(\"[A-Za-z ]+\")";

            int n = int.Parse(Console.ReadLine());

            long dataTransfer = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string senderRegex = match.Groups[1].Value;
                    string receiverRegex = match.Groups[2].Value;
                    string message = match.Groups[3].Value;

                    string sender = new String(senderRegex.Where(Char.IsLetter).ToArray());
                    string reciver = new String(receiverRegex.Where(Char.IsLetter).ToArray());

                    for (int j = 0; j < senderRegex.Length; j++)
                    {
                        if (senderRegex[j] == '0' || senderRegex[j] == '1' || senderRegex[j] == '2' || senderRegex[j] == '3' || senderRegex[j] == '4' || 
                            senderRegex[j] == '5' || senderRegex[j] == '6' || senderRegex[j] == '7' || senderRegex[j] == '8' || senderRegex[j] == '9')
                        {
                            dataTransfer += long.Parse(senderRegex[j].ToString());
                        }
                    }

                    for (int j = 0; j < receiverRegex.Length; j++)
                    {
                        if (receiverRegex[j] == '0' || receiverRegex[j] == '1' || receiverRegex[j] == '2' || receiverRegex[j] == '3' || receiverRegex[j] == '4' ||
                            receiverRegex[j] == '5' || receiverRegex[j] == '6' || receiverRegex[j] == '7' || receiverRegex[j] == '8' || receiverRegex[j] == '9')
                        {
                            dataTransfer += long.Parse(receiverRegex[j].ToString());
                        }
                    }

                    Console.WriteLine($"{sender} says {message} to {reciver}");
                }
            }

            Console.WriteLine($"Total data transferred: {dataTransfer}MB");

        }
    }
}
