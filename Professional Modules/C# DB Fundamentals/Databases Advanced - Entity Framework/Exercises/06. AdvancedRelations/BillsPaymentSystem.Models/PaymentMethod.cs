using BillsPaymentSystem.Models.Attributes;
using BillsPaymentSystem.Models.Enums;

namespace BillsPaymentSystem.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }

        public PaymentType Type { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        [Xor(nameof(BankAccount))]
        public int? CreditCardtId { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}