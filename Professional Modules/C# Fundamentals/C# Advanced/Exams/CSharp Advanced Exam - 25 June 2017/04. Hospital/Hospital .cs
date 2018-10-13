﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> departmentPatients = new Dictionary<string, HashSet<string>>();
            Dictionary<string, SortedSet<string>> doctorsPatients = new Dictionary<string, SortedSet<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Output")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string departament = tokens[0];
                string doctor = string.Concat(tokens[1], " ", tokens[2]);
                string patient = tokens[3];

                if (!departmentPatients.ContainsKey(departament))
                {
                    departmentPatients.Add(departament, new HashSet<string>());
                }
                else
                {
                    if (departmentPatients[departament].Count() + 1 > 60)
                    {
                        continue;
                    }
                }

                departmentPatients[departament].Add(patient);

                if (!doctorsPatients.ContainsKey(doctor))
                {
                    doctorsPatients.Add(doctor, new SortedSet<string>());
                }

                doctorsPatients[doctor].Add(patient);
            }

            string commandLine = string.Empty;

            while ((commandLine = Console.ReadLine()) != "End")
            {
                string[] command = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command.Length == 1)
                {
                    PrintDepartmentPatients(command[0], departmentPatients);
                }
                else if (command[1].All(char.IsDigit))
                {
                    PrintRoomPatients(command[0], int.Parse(command[1]), departmentPatients);
                }
                else
                {
                    PrintDoctorPatients(command[0] + " " + command[1], doctorsPatients);
                }
            }
        }

        private static void PrintDoctorPatients(string doctor, Dictionary<string, SortedSet<string>> doctorsPatients)
        {
            var patientsByDoctor = doctorsPatients
             .Where(x => x.Key == doctor)
             .Select(x => x.Value);

            foreach (var patients in patientsByDoctor)
            {
                foreach (var patient in patients.OrderBy(x => x))
                {
                    Console.WriteLine(patient);
                }
            }
        }

        private static void PrintRoomPatients(string command, int room, Dictionary<string, HashSet<string>> departmentPatients)
        {
            foreach (var patient in departmentPatients[command].Skip((room - 1) * 3).Take(3).OrderBy(x => x))
            {
                Console.WriteLine(patient);
            }
        }

        private static void PrintDepartmentPatients(string command, Dictionary<string, HashSet<string>> departmentPatients)
        {
            foreach (var patient in departmentPatients[command])
            {
                Console.WriteLine(patient);
            }
        }
    }
}