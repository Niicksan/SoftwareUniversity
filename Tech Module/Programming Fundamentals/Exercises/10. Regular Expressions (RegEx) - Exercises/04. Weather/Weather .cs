using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"([A-Z]{2})([0-9]+.[0-9]+)([A-Za-z]+)\|");

            Dictionary<string, KeyValuePair<double, string>> forecast = new Dictionary<string, KeyValuePair<double, string>>();
            while (input != "end")
            {

                string city = "";
                double temp = 0;
                string typeOfWeather = "";

                foreach (Match match in pattern.Matches(input))
                {
                    city = match.Groups[1].Value;
                    temp = double.Parse(match.Groups[2].Value);
                    typeOfWeather = match.Groups[3].Value;
                }
                if (city != "" && temp != 0 && typeOfWeather != "")
                {
                    if (!forecast.ContainsKey(city))
                    {
                        forecast[city] = new KeyValuePair<double, string>(temp, typeOfWeather);
                    }
                    else
                    {
                        forecast[city] = new KeyValuePair<double, string>(temp, typeOfWeather);
                    }    
                }

                input = Console.ReadLine();
            }

            var sortedDict = forecast.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var d in sortedDict)
            {
                Console.WriteLine($"{d.Key} => {d.Value.Key:f2} => {d.Value.Value}");
            }

        }
    }
}
