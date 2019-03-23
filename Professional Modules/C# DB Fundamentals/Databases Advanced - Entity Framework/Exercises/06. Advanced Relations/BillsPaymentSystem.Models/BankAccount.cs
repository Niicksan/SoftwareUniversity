using System;
using System.Collections.Generic;
using System.Text;

namespace BillsPaymentSystem.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public decimal Balance {get; set; }

        public string BankName { get; set; }

        public string SwiftCode { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid operation");
            }

            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 0 || amount <= 0)
            {
                throw new Exception("Invalid operation");
            }

            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"-- ID: {this.BankAccountId}" + Environment.NewLine +
                  $"--- Balance: {this.Balance:f2}" + Environment.NewLine +
                  $"--- Bank: {this.BankName}" + Environment.NewLine +
                  $"--- SWIFT: {this.SwiftCode}";
        }
    }
}
