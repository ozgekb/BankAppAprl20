using System;
namespace BankApp
{   enum TypeOfTransaction
    {
            Credit,
            Debit
    }
    class Transaction
    {
        public int id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public TypeOfTransaction TransactionType { get; set; }
        public int AccountNumber { get; set; }

    }
}
