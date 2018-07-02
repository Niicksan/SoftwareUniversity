using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(.+?(?=\@))*@([A-Za-z]+)([^@:!\->]*):([0-9]+)([^@:!\->]*)!([AD])!([^@:!\->]*)->([0-9]+)(.+?(?=$))*");

            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = "";
                int count = 0;
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    if (encryptedMessage[j] == 'S' ||
                        encryptedMessage[j] == 's' ||
                        encryptedMessage[j] == 'T' ||
                        encryptedMessage[j] == 't' ||
                        encryptedMessage[j] == 'A' ||
                        encryptedMessage[j] == 'a' ||
                        encryptedMessage[j] == 'R' ||
                        encryptedMessage[j] == 'r')
                    { 
                        count++;
                     }
                }

                for (int k = 0; k < encryptedMessage.Length; k++)
                {
                    int decryptedlettter = encryptedMessage[k] - count;
                    decryptedMessage += (char)decryptedlettter;
                }

                Match match = pattern.Match(decryptedMessage);
                if (match.Success)
                {
                    string planetName = match.Groups[2].Value;
                    string attack = match.Groups[6].Value; ;

                    if (attack == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attack == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count != 0)
            {
                foreach (var planet in attackedPlanets.OrderBy(planet => planet))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count != 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(planet => planet))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
