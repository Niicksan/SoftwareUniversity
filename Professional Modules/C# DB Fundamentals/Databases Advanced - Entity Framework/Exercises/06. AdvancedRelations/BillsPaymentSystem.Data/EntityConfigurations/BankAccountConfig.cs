using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillsPaymentSystem.Data.EntityConfigurations
{
    public class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> entity)
        {
            entity.HasKey(e => e.BankAccountId);

            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            entity.Property(e => e.SwiftCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();

            entity.Ignore(e => e.PaymentMethod);
        }
    }
}