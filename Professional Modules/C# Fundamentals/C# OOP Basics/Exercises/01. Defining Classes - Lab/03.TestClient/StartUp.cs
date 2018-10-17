using System;
using System.Collections.Generic;

namespace _03.TestClient
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string command = input[0];

                switch (command)
                {
                    case "Create":
                        Create(input, accounts);
                        break;
                    case "Deposit":
                        Deposit(input, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(input, accounts);
                        break;
                    case "Print":
                        Print(input, accounts);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }

        private static void Print(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(input[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine($"Account ID{accounts[id].Id}, balance {accounts[id].Balance:f2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            } 
        }

        private static void Withdraw(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(input[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                decimal amount = decimal.Parse(input[2]);

                if (amount > accounts[id].Balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Balance -= amount;
                }
            }
        }

        private static void Deposit(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(input[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                decimal amount = decimal.Parse(input[2]);

                accounts[id].Balance += amount;
            }
        }

        private static void Create(string[] input, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(input[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount account = new BankAccount();

                account.Id = id;
                accounts.Add(id, account);
            }
        }
    }
}
