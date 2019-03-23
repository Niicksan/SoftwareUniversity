using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillsPaymentSystem.Data.EntityConfigurations
{
    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasIndex(e => new { e.UserId, e.CreditCardtId, e.BankAccountId }).IsUnique();

            entity.HasOne(e => e.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(e => e.UserId);

            entity.HasOne(e => e.BankAccount)
                .WithOne(c => c.PaymentMethod)
                .HasForeignKey<PaymentMethod>(e => e.BankAccountId);

            entity.HasOne(e => e.CreditCard)
                .WithOne(c => c.PaymentMethod)
                .HasForeignKey<PaymentMethod>(e => e.CreditCardtId);
        }
    }
}
