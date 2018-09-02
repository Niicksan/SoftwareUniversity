using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] inputElements = Console.ReadLine().Split().ToArray();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (inputElements[0] != "END")
            {
                string name = inputElements[1];

                if (inputElements[0] == "A")
                {
                    string phone = inputElements[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }
                    else
                    {
                        phonebook[name] = phone;
                    }
                }
                else if (inputElements[0] == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        foreach (var item in phonebook)
                        {
                            if (item.Key == name)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                inputElements = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
