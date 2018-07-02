using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            Dictionary<string, List<string>> languagePoints = new Dictionary<string, List<string>>();
            Dictionary<string, List<long>> usernamePoitns = new Dictionary<string, List<long>>();
            while (command != "exam finished")
            {
                string[] commandData = command.Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandData.Length > 2)
                {
                    string username = commandData[0];
                    string language = commandData[1];
                    long points = long.Parse(commandData[2]);

                    List<string> listLang = new List<string>();
                    List<long> listPoints = new List<long>();
                    if (!usernamePoitns.ContainsKey(username))
                    {
                        listPoints.Add(points);
                        usernamePoitns.Add(username, listPoints);
                    }
                    else
                    {
                        usernamePoitns[username].Add(points);
                    }

                    if (!languagePoints.ContainsKey(language))
                    {
                        listLang.Add(language);
                        languagePoints.Add(language, listLang);
                    }
                    else
                    {
                        languagePoints[language].Add(language);
                    }
                    
                }
                else
                {
                    string user = commandData[0];
                    foreach (var item in usernamePoitns.Keys)
                    {
                        if (item == user)
                        {
                            usernamePoitns.Remove(item);
                            break;
                        }
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var name in usernamePoitns
                .OrderByDescending(e => e.Value.Max())
                .ThenBy(e => e.Key))
            {
                Console.WriteLine($"{name.Key} | {name.Value.Max()}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in languagePoints
                .OrderByDescending(e => e.Value.Count())
                .OrderBy(e => e.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value.Count()}");
            }
        }
    }
}
