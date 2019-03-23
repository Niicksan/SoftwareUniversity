using BillsPaymentSystem.Data;
using BillsPaymentSystem.Models;
using BillsPaymentSystem.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BillsPaymentSystem.App
{
    
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var dbContext = new BillsPaymentSystemContext())
            {
                dbContext.Database.EnsureCreated();

                Seed(dbContext);

                Console.Write($"Enter an user ID [{(dbContext.Users.Any() ? 1 : 0)} - " +
                    $"{dbContext.Users.Last().UserId}]: ");
                int userId = int.Parse(Console.ReadLine());

                var isUserFound = dbContext.Users.Find(userId) != null;

                if (isUserFound)
                {
                    var user = dbContext.Users
                      .Where(u => u.UserId == userId)
                      .Select(u => new
                      {
                          Name = $"{u.FirstName} {u.LastName}",
                          BankAccounts = u.PaymentMethods
                              .Where(pm => pm.Type == PaymentType.BankAccount)
                              .Select(pm => pm.BankAccount)
                              .ToList(),
                          CreditCards = u.PaymentMethods
                              .Where(pm => pm.Type == PaymentType.CreditCard)
                              .Select(pm => pm.CreditCard)
                              .ToList()
                      })
                      .First();

                    Console.WriteLine($"User: {user.Name}");

                    if (user.BankAccounts.Count > 0)
                    {
                        Console.WriteLine($"Bank Accounts: {Environment.NewLine}{String.Join(Environment.NewLine, user.BankAccounts)}");
                    }

                    if (user.CreditCards.Count > 0)
                    {
                        Console.WriteLine($"Credit Cards: {Environment.NewLine}{String.Join(Environment.NewLine, user.CreditCards)}");
                    }
                }
                else
                {
                    Console.WriteLine($"User with id {userId} not found!");
                }
            }

            PayBills();
        }

        static void PayBills()
        {
            using (var dbContext = new BillsPaymentSystemContext())
            {
                try
                {
                    Console.WriteLine("Bills Payment");
                    Console.Write("Enter User ID: ");
                    int userId = int.Parse(Console.ReadLine());

                    Console.Write("Enter amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    var accounts = dbContext.PaymentMethods
                        .Include(pm => pm.BankAccount)
                        .Where(pm => pm.UserId == userId && pm.Type == PaymentType.BankAccount)
                        .Select(pm => pm.BankAccount)
                        .ToList();

                    var cards = dbContext.PaymentMethods
                        .Include(pm => pm.CreditCard)
                        .Where(pm => pm.UserId == userId && pm.Type == PaymentType.CreditCard)
                        .Select(pm => pm.CreditCard)
                        .ToList();

                    var moneyAvailable = accounts.Select(ba => ba.Balance).Sum() + cards.Select(cc => cc.LimitLeft).Sum();

                    if (moneyAvailable < amount)
                    {
                        throw new Exception("Insufficient Funds");
                        return;
                    }

                    foreach (var account in accounts)
                    {
                        if (amount == 0 || account.Balance == 0)
                        {
                            continue;
                        }

                        decimal moneyInAccount = account.Balance;

                        if (moneyInAccount < amount)
                        {
                            account.Withdraw(moneyInAccount);
                            amount -= moneyInAccount;
                        }
                        else
                        {
                            account.Withdraw(amount);
                            amount -= amount;
                        }
                    }

                    foreach (var creditCard in cards)
                    {
                        if (amount == 0 || creditCard.LimitLeft == 0)
                        {
                            continue;
                        }

                        decimal limitLeft = creditCard.LimitLeft;

                        if (limitLeft < amount)
                        {
                            creditCard.Withdraw(limitLeft);
                            amount -= limitLeft;
                        }
                        else
                        {
                            creditCard.Withdraw(amount);
                            amount -= amount;
                        }
                    }

                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

        }

        static void Seed(BillsPaymentSystemContext context)
        {
            var users = new[]
            {
                new User
                {
                    FirstName = "Aleko",
                    LastName = "Todorov",
                    Email = "aleko@abv.bg",
                    Password = "agaga"
                },

                new User
                {
                    FirstName = "Alisia",
                    LastName = "Ivanova",
                    Email = "alisia@yahoo.com",
                    Password = "agavgww"
                },

                new User
                {
                    FirstName = "Neli",
                    LastName = "Petkova",
                    Email = "neli@gmail.com",
                    Password = "agwaggggg"
                },

                new User
                {
                    FirstName = "Vladi",
                    LastName = "Nikolav",
                    Email = "vlad87@abv.bg",
                    Password = "agwqtwr"
                }
            };

            context.Users.AddRange(users);

            var creditCards = new[]
            {
                new CreditCard
                {
                    Limit = 24000.00m,
                    MoneyOwed = 1100.00m,
                    ExpirationDate = new DateTime(2019, 2, 2),
                },

                new CreditCard
                {
                    Limit = 11000.00m,
                    MoneyOwed = 3500.00m,
                    ExpirationDate = new DateTime(2019, 8, 11),
                },

                new CreditCard
                {
                    Limit = 55000.00m,
                    MoneyOwed = 200.00m,
                    ExpirationDate = new DateTime(2018, 5, 19),
                },

                new CreditCard
                {
                    Limit = 15000.00m,
                    MoneyOwed = 1500.00m,
                    ExpirationDate = new DateTime(2020, 6, 10),
                },
            };

            context.CreditCards.AddRange(creditCards);

            var bankAccounts = new[]
            {
                new BankAccount{
                    Balance = 9435m,
                    BankName = "Investbank",
                    SwiftCode = "TGBHJKL"
                },

                new BankAccount{
                    Balance = 7000m,
                    BankName = "Expresbank",
                    SwiftCode = "FRJRJWS"
                },

                new BankAccount{
                    Balance = 5466m,
                    BankName = "Raiffensen",
                    SwiftCode = "FMJEJE"
                },

                new BankAccount{
                    Balance = 9461m,
                    BankName = "DSK",
                    SwiftCode = "FKJJDSWW"
                }
            };

            context.BankAccounts.AddRange(bankAccounts);

            var paymentMethods = new[]
            {
                new PaymentMethod
                {
                    User = users[1],
                    Type = PaymentType.BankAccount,
                    BankAccount = bankAccounts[0]
                },

                new PaymentMethod
                {
                    User = users[2],
                    Type = PaymentType.BankAccount,
                    BankAccount = bankAccounts[1]
                },

                new PaymentMethod
                {
                    User = users[3],
                    Type = PaymentType.CreditCard,
                    CreditCard = creditCards[3]
                },

                new PaymentMethod
                {
                    User = users[0],
                    Type = PaymentType.CreditCard,
                    CreditCard = creditCards[1]
                },

                new PaymentMethod
                {
                    User = users[1],
                    Type = PaymentType.BankAccount,
                    BankAccount = bankAccounts[2]
                },

                new PaymentMethod
                {
                    User = users[2],
                    Type = PaymentType.CreditCard,
                    CreditCard = creditCards[2]
                },

                new PaymentMethod
                {
                    User = users[3],
                    Type = PaymentType.CreditCard,
                    CreditCard = creditCards[3]
                },

                new PaymentMethod
                {
                    User = users[0],
                    Type = PaymentType.BankAccount,
                    BankAccount = bankAccounts[1]
                }
            };

            context.PaymentMethods.AddRange(paymentMethods);

            context.SaveChanges();
        }
    }
}