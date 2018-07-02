using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
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

                else if (contacts[0] == "ListAll")
                {
                    foreach (var contact in phoneBook.OrderBy(contact => contact.Key))
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
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
