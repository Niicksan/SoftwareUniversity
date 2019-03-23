using System;
using System.Collections.Generic;
using System.Text;

namespace BillsPaymentSystem.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }

        public decimal Limit { get; set; }

        public decimal MoneyOwed { get; set; }

        public decimal LimitLeft => Limit - MoneyOwed;

        public DateTime ExpirationDate { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid operation");
            }

            this.MoneyOwed -= amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.LimitLeft < amount || amount <= 0)
            {
                throw new Exception("Invalid operation");
            }

            this.MoneyOwed += amount;
        }

        public override string ToString()
        {
            return $"-- ID: {this.CreditCardId}" + Environment.NewLine +
                   $"--- Limit: {this.Limit:f2}" + Environment.NewLine +
                   $"--- Money Owed: {this.MoneyOwed:f2}" + Environment.NewLine +
                   $"--- Limit Left: {this.LimitLeft:f2}" + Environment.NewLine +
                   $"--- Expiration Date: {this.ExpirationDate.ToString("yyyy/MM")}";
        }
    }
}
