using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<List<string>, int>> idLogs = new Dictionary<string, Dictionary<List<string>, int>>();
            Dictionary<List<string>, int> ipsANdCount = new Dictionary<List<string>, int>();
            while (input != "end")
            {
                string[] logInfo = input.Split().ToArray();
                List<string> ipAdresses = new List<string>();


                string fullIP = logInfo[0];
                string message = logInfo[1];
                string FullUserName = logInfo[2];
                string ip = "";
                string user = "";

                int count = 1;
                for (int i = 3; i < fullIP.Length; i++)
                {
                    ip += fullIP[i].ToString();
                }

                for (int i = 5; i < FullUserName.Length; i++)
                {
                    user += FullUserName[i].ToString();
                }

                if (idLogs.ContainsKey(user))
                {
                    foreach (var ips in ipsANdCount)
                    {
                        if (ips.Key.Contains(ip))
                        {
                            
                        }
                        else
                        {
                            ipAdresses.Add(ip);
                        }

                    }
                }
                else
                {
                    idLogs.Add(user, ipsANdCount);
                }
                input = Console.ReadLine();
            }

            foreach (var user in idLogs.OrderBy(key => key.Key))
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine(string.Join(" =>, ", user.Value) + ".");
            }
        }
    }
}
