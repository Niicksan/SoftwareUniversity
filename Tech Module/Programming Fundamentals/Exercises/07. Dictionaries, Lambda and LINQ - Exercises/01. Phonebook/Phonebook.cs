using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] contacts = Console.ReadLine().Split().ToArray();

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (contacts[0] != "END")
            {
               
                if (contacts[0] == "A")
                {
                    AddUpdateContact(phoneBook, contacts);
                }
                else if (contacts[0] == "S")
                {
                    SearchContact(phoneBook, contacts);
                }

                contacts = Console.ReadLine().Split().ToArray();
            }
        }

        private static void AddUpdateContact(Dictionary<string, string> phoneBook, string[] contacts)
        {
            if (phoneBook.ContainsKey(contacts[1]))
            {
                phoneBook[contacts[1]] = contacts[2];
            }
            else
            {
                phoneBook.Add(contacts[1], contacts[2]);
            }
        }

        private static void SearchContact(Dictionary<string, string> phoneBook, string[] contacts)
        {
            if (phoneBook.ContainsKey(contacts[1]))
            {
                Console.WriteLine($"{contacts[1]} -> {phoneBook[contacts[1]]}");

            }
            else
            {
                Console.WriteLine($"Contact {contacts[1]} does not exist.");
            }
        }
    }
}
